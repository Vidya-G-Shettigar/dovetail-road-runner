import { Component, OnInit, Renderer2, Inject } from '@angular/core';
import { Router } from '@angular/router';
import { DOCUMENT } from '@angular/common';
import headder from '../../../../assets/road-runner/content/headder.json';
import { FieldName } from '../../../enum/app-constant.enum';
@Component({
  selector: 'app-global-headder',
  templateUrl: './global-headder.component.html',
  styleUrls: ['./global-headder.component.css'],
})
export class GlobalHeadderComponent implements OnInit {
  public searchInput: String = '';
  public searchResult: Array<any> = [];
  public seriesList: Array<any> = [
    {
      "name": "Workers Compensation"
    },
    {
      "name": "Komene Gardens"
    },
    {
    "name": "Brady Cafe's"
    },
    {
    "name": "Business Owner's Policy"
    },
    {
    "name": "Umbrella"
    }
    ]
   
   fetchSeries(event: any) {
    if (event.target.value === '') {
      return this.searchResult = [];
    } 
    this.searchResult = this.seriesList.filter((series) => {
      return series.name.toLowerCase().startsWith(event.target.value.toLowerCase());
    })
    return 0;
  }

  HeadderData: any;
  router: string;
  readonly days = 14;
  collapse = false;
  isErrorComponent = false;
  contactUsLink: any;
  resourcesMenu: any;
  multiDropdown: any;
  isColleagueRoute = false;
  private currentRouteName: string;
  constructor(
    @Inject(DOCUMENT) readonly document: Document,
    private _router: Router,

    readonly renderer: Renderer2
  ) {
    this.HeadderData = headder;
    this.router = _router.url;
  }

  ngOnInit(): void {
    console.log(headder.mobileMenu.close);
  }

  showModal(): any {
    this.renderer.addClass(this.document.body, 'open-fullscreen-modal');
    this.collapse = false;
    return {
      type: 'component-modal',
      showHeader: false,
    };
  }

  toggleNavigation() {
    this.collapse = this.collapse ? false : true;
    console.log('test');
  }
  toggleSubLinks(row: any) {
    row.collapse = row.collapse ? false : true;
  }

  closeNavigation(linkName?: string) {
    this.collapse = false;
    this.renderer.removeClass(this.document.body, 'open-fullscreen-modal');
    if (linkName && linkName === FieldName.DALLAR_SIGN) {
    }
  }

  // Redirect on rating state to create quote 
}
