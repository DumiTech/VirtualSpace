import { Photo } from './photo';

export interface Member {
  id: number;
<<<<<<< HEAD
  userName: string;
=======
  username: string;
>>>>>>> b4b9322026ea1e9bb5e94698869094a105ddd495
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


