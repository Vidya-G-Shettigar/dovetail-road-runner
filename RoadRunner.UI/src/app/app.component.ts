import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {

  title = 'road-runner';
  states = [
    {
      name: 'New York',
      code: 'NY',
      Business: [
        {
          name: 'Businers Owner policy',
          image: '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
          redirectUrl: '/portfolio/quotes',
        },
        {
          name: 'General Liability',
          image: '/assets/road-runner/images/icons/GeneralLiability.png',
          redirectUrl: '/portfolio/quotes',
        },
        {
          label: 'Get Quote',
        },
      ],
    },
    {
      name: 'Tirupati',
      code: 'tr',
      Business: [
        {
          name: 'Workers Compensation',
          image: '/assets/road-runner/images/icons/WorkersCompensation.png',
          redirectUrl: '/portfolio/quotes',
        },
        {
          name: 'Businers Owner policy',
          image: '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
          redirectUrl: '/portfolio/quotes',
        },
        {
          name: 'General Liability',
          image: '/assets/road-runner/images/icons/GeneralLiability.png',
          redirectUrl: '/portfolio/quotes',
        },
        {
          name: 'Cyber Liability',
          image:
            '/assets/road-runner/images/icons/Icon_CyberLiability_Blue.png',
          redirectUrl: '/portfolio/quotes',
        },
      ],
    },
    { name: 'Karnataka', code: 'ka' },
    { name: 'bangalore', code: 'bl' },
  ];
}