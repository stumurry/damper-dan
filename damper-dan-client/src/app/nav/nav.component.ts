import { Component, OnInit, Input } from "@angular/core";
import { AuthService } from "../service/auth.service";
import { Router } from "@angular/router";
import { AngularFireAuth } from "angularfire2/auth";

import { MenuItem } from "primeng/api";

@Component({
  selector: "app-nav",
  templateUrl: "./nav.component.html",
  styleUrls: ["./nav.component.css"]
})
export class NavComponent implements OnInit {
  items: MenuItem[];

  @Input() name: string = "<Not Set>";

  constructor(
    private authService: AuthService,
    private router: Router,
    private afa: AngularFireAuth
  ) {}

  ngOnInit() {
    this.items = [
      {
        label: "File",
        items: [
          {
            label: "New",
            icon: "fa fa-fw fa-plus",
            items: [{ label: "Project" }, { label: "Other" }]
          },
          { label: "Open" },
          { label: "Quit" }
        ]
      },
      {
        label: "Edit",
        icon: "fa fa-fw fa-edit",
        items: [
          { label: "Undo", icon: "fa fa-fw fa-mail-forward" },
          { label: "Redo", icon: "fa fa-fw fa-mail-reply" }
        ]
      }
    ];
  }

  logout() {
    this.afa.auth.signOut();
  }
}
