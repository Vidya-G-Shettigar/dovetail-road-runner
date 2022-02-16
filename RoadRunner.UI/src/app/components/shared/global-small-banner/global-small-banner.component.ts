import { Component, OnInit } from '@angular/core';
// import policies from '../../../../assets/road-runner/content/policies.json';
import { JsonfetchService } from '../../../services/jsonfetch.service';
import { Router } from '@angular/router';
import { FileUploadModule } from 'primeng/fileupload';
import { HttpClientModule } from '@angular/common/http';
@Component({
  selector: 'app-global-small-banner',
  templateUrl: './global-small-banner.component.html',
  styleUrls: ['./global-small-banner.component.css'],
})
export class GlobalSmallBannerComponent implements OnInit {
  buttonRouter: string;
  lastPartRout: any;
  uploadedFiles: any[] = [];
  data: any;
  ifError = false;
  errorMsg = null;
  errorCode = null;

  // private subscription: Subscription;
  constructor(private router: Router, private fetchjson: JsonfetchService) {
    // this.banner = policies;

    this.buttonRouter = router.url;
    this.lastPartRout = this.buttonRouter.split('?')[0].split('/').pop();
    console.log(this.lastPartRout);
  }

  getData() {
    this.fetchjson.getData().subscribe(
      (response: any) => {
        this.data = response;
        // console.log(this.data);
      },

      (error) => {
        // this.errorMsg = error.error.error;
        // this.errorCode = error.status;
        // console.log('error');
      }
    );
  }

  ngOnInit(): void {
    this.getData();
    // console.log('oninit');
  }
}
