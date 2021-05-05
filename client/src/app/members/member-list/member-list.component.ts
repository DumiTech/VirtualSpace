import { Component, OnInit } from '@angular/core';
<<<<<<< HEAD
import { Observable } from 'rxjs';
=======
>>>>>>> b4b9322026ea1e9bb5e94698869094a105ddd495
import { Member } from 'src/app/models/member';
import { MembersService } from 'src/app/services/members.service';

@Component({
  selector: 'app-member-list',
  templateUrl: './member-list.component.html',
  styleUrls: ['./member-list.component.css']
})

export class MemberListComponent implements OnInit {
<<<<<<< HEAD
  members$: Observable<Member[]>; //  convention to specify that this is an observable => $, rather than just a normal JS object
=======
  members: Member[];
>>>>>>> b4b9322026ea1e9bb5e94698869094a105ddd495

  constructor(private memberService: MembersService) { }

  ngOnInit(): void {
<<<<<<< HEAD
    this.members$ = this.memberService.getMembers(); // initialisation
=======
    this.loadMembers(); // initialisation
  }

  // tslint:disable-next-line:typedef
  loadMembers() {
    this.memberService.getMembers().subscribe(members => {  // subscribe because is an Observable
      this.members = members;
    });
>>>>>>> b4b9322026ea1e9bb5e94698869094a105ddd495
  }

}