import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Member } from 'src/app/models/member';
import { MembersService } from 'src/app/services/members.service';

@Component({
  selector: 'app-member-list',
  templateUrl: './member-list.component.html',
  styleUrls: ['./member-list.component.css']
})

export class MemberListComponent implements OnInit {
  members$: Observable<Member[]>; //  convention to specify that this is an observable => $, rather than just a normal JS object
  members: Member[];

  constructor(private memberService: MembersService) { }

  ngOnInit(): void {
    this.members$ = this.memberService.getMembers(); // initialisation
    this.loadMembers(); // initialisation
  }

  loadMembers() {
    this.memberService.getMembers().subscribe(members => {  // subscribe because is an Observable
      this.members = members;
    });
  }

}