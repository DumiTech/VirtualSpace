import { Photo } from './photo';

export interface Member {
  id: number;
  userName: string;
  username: string;
  photoUrl: string;
  age: number;
  knownAs: string;
  created: Date;
  lastActive: Date;
  gender: string;
  introduction: string;
  favorites: any;
  hobbies: string;
  interests: string;
  city: string;
  country: string;
  photos: Photo[];
}


