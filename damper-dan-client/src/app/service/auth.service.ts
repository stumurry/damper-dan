import { Injectable } from "@angular/core";
import { AngularFireAuth } from "angularfire2/auth";
import {
  AngularFirestore,
  AngularFirestoreCollection,
  AngularFirestoreDocument
} from "angularfire2/firestore";
import "rxjs/Rx";
import { Observable } from "rxjs";
import { ActivatedRoute, Router } from "@angular/router";
import {  } from "../app";
import * as firebase from "firebase/app";

@Injectable()
export class AuthService {

  constructor(
    private afa: AngularFireAuth,
  ) {
    //https://stackoverflow.com/questions/35110690/ngoninit-not-being-called-when-injectable-class-is-instantiated
  }

  logout() {
    this.afa.auth.signOut();
  }


}
