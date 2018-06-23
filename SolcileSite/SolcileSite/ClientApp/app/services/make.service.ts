import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';
//import { map } from 'rxjs/operator/map';
//import { map } from 'rxjs/operator/map';

@Injectable()

export class MakeService {

    constructor(private http: Http) { }
    getMake() {
        return this.http.get('/api/makes')
    .map(res => res.json());

    }
    getFeature() {
        return this.http.get('/api/feature')
            .map(res => res.json());
    }
}
