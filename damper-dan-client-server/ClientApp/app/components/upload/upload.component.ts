import { Component, Inject  } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'upload',
    templateUrl: './upload.component.html',
    styleUrls: ['./upload.component.css']
})
export class UploadComponent {

    constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string) {}

    data : any;

    onSubmit() {
        this.http.post(this.baseUrl + 'api/tester/dampers', JSON.stringify(this.data)).subscribe(result => {
            console.log(result);
            this.dampers = result.json();
        }, error => console.error(error));

        // this.http.post('http://someurl', JSON.stringify(this.data))
        // .subscribe(...);
        // console.log('Hello World');
    }
}
