import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';

@Injectable()
export class GroupService {

  constructor(private http: Http) { }

  getGroups(){
    return this.http.get('/api/groups')
      .map(res => res.json());
  }
}
