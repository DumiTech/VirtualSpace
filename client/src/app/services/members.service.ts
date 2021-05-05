import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
<<<<<<< HEAD
import { of } from 'rxjs';
import { map } from 'rxjs/operators';
=======
>>>>>>> b4b9322026ea1e9bb5e94698869094a105ddd495
import { environment } from 'src/environments/environment';
import { Member } from '../models/member';


@Injectable({
  providedIn: 'root'
})
export class MembersService {
  baseUrl = environment.apiUrl;
<<<<<<< HEAD
  members: Member[] = [];

  constructor(private http: HttpClient) { }

  getMembers() {
    if (this.members.length > 0) return of (this.members);
    return this.http.get<Member[]>(this.baseUrl + 'users').pipe(
      map(members => {
        this.members = members;
        return members;
      })
    )
  }

  getMember(username: string) {
    const member = this.members.find(x => x.userName === username);
    if (member !== undefined) return of(member);
    return this.http.get<Member>(this.baseUrl + 'users/' + username);
  }

  updateMember(member: Member) {
    return this.http.put(this.baseUrl + 'users', member).pipe( 
      map(() => {
        const index = this.members.indexOf(member);
        this.members[index] = member;
      })
    )
  }
=======

  constructor(private http: HttpClient) { }

  // tslint:disable-next-line:typedef
  getMembers() {
    return this.http.get<Member[]>(this.baseUrl + 'users');
  }
  // tslint:disable-next-line:typedef
  getMember(username: string) {
    return this.http.get<Member>(this.baseUrl + 'users/' + username);
  }
>>>>>>> b4b9322026ea1e9bb5e94698869094a105ddd495
}
