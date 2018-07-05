import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'dampers',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    public dampers: any;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/tester/dampers').subscribe(result => {
            console.log(result);
            this.dampers = result.json();
        }, error => console.error(error));
    }
}


