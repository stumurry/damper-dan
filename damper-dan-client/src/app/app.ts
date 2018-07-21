export interface Character {
    CharacterID : any;
}

export interface Building {
    buildingId : number;
    AliasID : string;
    marker : Marker;
    buildingName : string;
    SelectedFloor? : Floor;
}

export interface Marker {
    lat : number;
    lng : number;
    label? : String;
    draggable : boolean;
   
}

export interface Damper {
    id : number;
    alias : string,
    location : string,
    sublocation : string,
    sizel : number,
    sizew : number,
    comment : string,
    statusid : number
}

export interface Floor {
    id : number;
    label : string;

}

export interface SelectedItem {
    label : string;
    value : Floor;

}