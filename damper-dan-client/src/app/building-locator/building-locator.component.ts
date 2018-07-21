import { Component, OnInit } from "@angular/core";

import {} from "@types/googlemaps";
import { Marker, Building, Damper, Floor, SelectedItem } from "../app";
import { Observable, Subject } from "rxjs";
import { HttpClient } from "@angular/common/http";
import { switchMap } from "rxjs/operators";
import { pipe } from "rxjs/internal/util/pipe";
import { environment } from "../../environments/environment";

@Component({
  selector: "app-building-locator",
  templateUrl: "./building-locator.component.html",
  styleUrls: ["./building-locator.component.scss"]
})
export class BuildingLocatorComponent implements OnInit {
  constructor(private http: HttpClient) {}

  damperUrl : string = "http://localhost:5000/api/facilities/dampers";
  buildingsUrl : string =  "http://localhost:5000/api/facilities/buildings";
  $buildings : Observable<any>;
  $dampers? : Observable<any>;
  dampers?: Damper[];
  $floors? : Observable<any>;
  floors : Floor[];
  // google maps zoom level
  zoom: number = 8;

  selectedBuilding : Building;
  selectedFloor : Floor;

  // initial center position for the map
  lat: number = 40.7062548;
  lng: number = -73.8763038;

  buildings?: Building[];

  clickSelectedFloor(f) {
    console.log(f);

    this.$dampers = this.http.get(`${environment.facilities}/building/${f.buildingId}/dampers`);
    this.$dampers.subscribe((d : any) => {
      console.log(d);
      // this.dampers = d.map(dd => {
      //   return {
      //     id: dd.id,
      //     alias: dd.alias_id
      //   };
      // });

      console.log("Lets go test some dampers on a floor.");
      console.log(d);
    });

  }

  clickMarker(building, index) {

    console.log('Marker Click')
    console.log(building);
    // this.$dampers = this.http.get(`${this.damperUrl}`);
    // this.$dampers.next(pipe(this.http.get(`${this.damperUrl}`)));

    this.selectedBuilding = building;

    this.$floors = this.http.get(`${environment.facilities}/buildings/${building.buildingId}/floors`);
    this.$floors.subscribe(f => {
      console.log('Getting some floors');
      console.log(f)
      this.floors = f.map(ff => {
        return {
          label : ff.floor_name,
          value : {
            id : ff.id,
            label : ff.floor_name,
          }
        }
      });

      console.log(this.floors);
    });
    
    
  }

  ngOnInit() {

    this.$buildings = this.http.get(`${this.buildingsUrl}`);
    
    this.$buildings.subscribe(b => {

      this.buildings = b.map(bb => {
        
        return {
          buildingId : bb.id,
          buildingName : bb.building_name,
          AliasID : bb.alias_id,
          marker: {
            label: bb.building_name,
            lat: bb.lat,
            lng: bb.lng
          }
        };
      });

    });
  }

  i: number = 3;

  mapClicked($event: any) {
    // this.buildings.push({
    //   marker: {
    //     buildingId: ++this.i,
    //     lat: $event.coords.lat,
    //     lng: $event.coords.lng,
    //     draggable: true
    //  }


  }

  markerDragEnd(m: Marker, $event: MouseEvent) {
    console.log("dragEnd", m, $event);
  }
}
