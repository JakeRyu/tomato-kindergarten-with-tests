import { GroupService } from './../../services/group.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-album-form',
  templateUrl: './album-form.component.html',
  styleUrls: ['./album-form.component.css']
})
export class AlbumFormComponent implements OnInit {
  groups: any;

  constructor(private groupService: GroupService) { }

  ngOnInit() {
    this.groupService.getGroups().subscribe(groups => {
      this.groups = groups;
      console.log("GROUPS:", this.groups);
    });
  }

}
