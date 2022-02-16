import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-product-availability',
  templateUrl: './product-availability.component.html',
  styleUrls: ['./product-availability.component.css'],
})
export class ProductAvailabilityComponent implements OnInit {
  iut1 = 'assets/road-runner/images/products/bop.png';
  iut2 = 'assets/road-runner/images/products/cyber_big.png';
  iut3 = 'assets/road-runner/images/General Liability.png';
  iut4 =
    'assets/road-runner/images/Product_Activate_Professional-Liability_Icon.png';
  iut5 = 'assets/road-runner/images/Product_Activate_Umbrella_Icon.png';
  iut6 = 'assets/road-runner/images/products/work.png';
  constructor() {}
  ngOnInit(): void {}
  selectedCity: any;
  value2: any;
  //   cities= [
  //     {name: 'New York', code: 'NY'},
  //     {name: 'Alabama', code: 'AL'},
  //     {name: 'Alaska', code: 'AK'},
  //     {name: 'Arizona', code: 'AZ'},
  //     {name: 'Arkansas', code: 'AR'},
  //     {name: 'California', code: 'CA'},
  //     {name: 'Colorado', code: 'CO'},
  //     {name: 'Delaware', code: 'DE'},
  //     {name: 'District of Columbia', code: 'DC'},
  //     {name: 'Florida', code: 'FL'},
  //     {name: 'Georgia', code: 'GA'},
  //     {name: 'Hawaii', code: 'HI'},
  //     {name: 'Idaho', code: 'ID'},
  //     {name: 'Illinois', code: 'IL'},
  //     {name: 'Iowa', code: 'IA'},
  //     {name: 'Indiana', code: 'IN'},
  //     {name: 'Kansas', code: 'KS'},
  //     {name: 'Montana', code: 'MT'},
  //     {name: 'Missouri', code: 'MO'},
  //     {name: 'Mississippi', code: 'MS'},
  //     {name: 'Minnesota', code: 'MN'},

  // ];
  cities = [
    {
      name: 'Alabama',
      code: 'AL',
      Business: [
        {
          name: 'Businers Owner Policy',
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
    { name: 'Alaska', code: 'AK' },
    { name: 'Arizona', code: 'AZ' },
    { name: 'Arkansas', code: 'AR' },
    { name: 'California', code: 'CA' },
  ];
  gettindDats: any;
  jsdata;
  selecte(e: any) {
    let searchbar = document.getElementById('searchbar');
    let iambckbtn = document.getElementById('iam-bckbtn');
    this.cities.forEach((kt) => {
      if (e.name == kt.name) {
        console.log('select');
        this.gettindDats = kt;
        console.log(typeof this.gettindDats);

        searchbar.style.display = 'none';
        iambckbtn.style.display = 'inline-block';
      }
    });
  }
  uclicked(ki) {
    // this.selectedfromDropdown(ki);
  }
  gobackToSearch() {
    let searchbar = document.getElementById('searchbar');
    let iambckbtn = document.getElementById('iam-bckbtn');
    this.value2 = '';
    // iamautoselect.innerText='cf'
    iambckbtn.style.display = 'none';
    searchbar.style.display = 'block';
  }
  heroes = [1, 2, 3, 4, 5, 6];

  searchCountr() {
    console.log('by clicking in to input tag');
  }
  selectedState: any = '';
  selectedfromDropdown(event: any) {
    let searchbar = document.getElementById('searchbar');
    let iambckbtn = document.getElementById('iam-bckbtn');
    this.cities.forEach((city) => {
      if (event.name == city.name) {
        console.log('data selectedfromDropdown');
        this.selectedState = event;
        console.log(event.name);
        searchbar.style.display = 'none';
        iambckbtn.style.display = 'inline-block';
      }
    });
  }
  filteredCountries: any[];
  searchCountry(event) {
    //in a real application, make a request to a remote url with the query and return filtered results, for demo we filter at client side
    console.log('iam seaqrching');
    let filtered: any[] = [];
    let query = event.query;
    for (let i = 0; i < this.cities.length; i++) {
      let country = this.cities[i];
      if (country.name.toLowerCase().indexOf(query.toLowerCase()) == 0) {
        filtered.push(country);
      }
    }

    this.filteredCountries = filtered;
  }
}
