import { Component, OnInit, ViewChild } from '@angular/core';
import { SortEvent } from 'primeng/api/sortevent';

import * as XLSX from 'xlsx';
import jsPDF from 'jspdf';
import autoTable from 'jspdf-autotable';
import { ExcelService } from 'src/app/services/excel.service';
import { Table } from 'primeng/table/table';
declare var $: any;

@Component({
  selector: 'app-policies',
  templateUrl: './policies.component.html',
  styleUrls: ['./policies.component.css'],
})
export class PoliciesComponent implements OnInit {
  @ViewChild('dt') dataTable: Table;
  customers: any[];
  representatives: any[];
  businessLine: any[];
  statuses: any[];
  loading: boolean = true;
  data: any;
  activequotes: any[];
  activityValues: number[] = [0, 100];
  colsForCsv: any[];
  exportColumns: any[];
  selectedProducts: any[] = [];
  selectedProductsExpired: any = [];
  colsForCsvExpired: any[];
  public selectedFilter: string = 'all';
  timePeriod = [];
  inpDataClientName = '';
  inpDataClientId = '';
  carrierDropDown = [];

  status = [];
  constructor(private excelService: ExcelService) { }

  expiredQuotes__data: any;
  ngOnInit() {
    this.timePeriod = [
      { label: '3 Months', value: '3' },
      { label: '6 Months', value: '6' },
      { label: '12 Months', value: '12' },
      { label: '24 Months', value: '24' },
    ];
    this.carrierDropDown = [
      { label: 'Am Trust', value: 'Am Trust' },
      { label: 'Markel', value: 'Markel' },
    ]
    this.status = [
      { label: 'All', value: 'all' },
      { label: 'Active', value: 'Active' },
      { label: 'To Renew', value: '18' },
      { label: 'Cancelled', value: '24' },
      { label: 'Pending Cancellation', value: '24' },
    ];
    this.representatives = [
      { name: 'Amy Elsner', image: 'amyelsner.png' },
      { name: 'Anna Fali', image: 'annafali.png' },
      { name: 'Asiya Javayant', image: 'asiyajavayant.png' },
      { name: 'Bernardo Dominic', image: 'bernardodominic.png' },
      { name: 'Elwin Sharvill', image: 'elwinsharvill.png' },
      { name: 'Ioni Bowcher', image: 'ionibowcher.png' },
      { name: 'Ivan Magalhaes', image: 'ivanmagalhaes.png' },
      { name: 'Onyama Limba', image: 'onyamalimba.png' },
      { name: 'Stephen Shaw', image: 'stephenshaw.png' },
      { name: 'XuXue Feng', image: 'xuxuefeng.png' },
    ];
    this.businessLine = [
      { name: 'Business Owners Policy-BOP' },
      { name: 'General Liability-GL' },
      { name: 'Professional Liability-PL' },
    ];

    this.activequotes = [
      {
        clientName: '',
        proposalName: '',
        proposall: '61952368e4f1083be4a2073b',
        policy: [
          {
            name: 'BOP',

            image: '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            status: 'Active',
            premium: 1500,
          },
          {
            name: 'GL',

            image: '/assets/road-runner/images/icons/GeneralLiability.png',
            status: 'Active',
            premium: 0,
          },
          {
            name: 'PL',

            image: '/assets/road-runner/images/icons/WorkersCompensation.png',
            status: 'To Renew',
            premium: 0,
          },
        ],
        statis: ['Active', 'In Progress', 'Awaiting Bind'],
        state: 'FL',
        dateCreated: '01/25/2020',
        status: 'Active',
        premium: [1500, 0, 0],
        createdBY: 'Eve Sample',
        carrier: 'Am Trust',
        downloadIcon:
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        clientName: 'Anderson Christopher',
        proposalName: 'Christopher',
        proposall: '61950df0e4f1083be4a2072d',
        policy: [
          {
            name: 'BOP',

            image: '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            status: 'In Progress',
            premium: 900,
          },
        ],
        statis: ['In Progress'],

        state: 'NY',
        dateCreated: '01/14/2020',
        status: 'Issued',
        premium: [900],
        createdBY: 'David Sample',
        carrier: 'Markel',
        downloadIcon:
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        clientName: 'Williams Richard',
        proposalName: 'Richard',
        proposall: '6195134fe4f1083be4a20736',
        policy: [
          {
            name: 'BOP',

            image: '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            status: 'In Progress',
            premium: 200,
          },
        ],
        statis: ['In Progress'],
        state: 'AZ',
        dateCreated: '12/15/2019',
        status: 'Issued',
        premium: [200],
        createdBY: 'Eve Sample',
        carrier: 'Markel',
        downloadIcon:
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        clientName: 'Walker Elizabeth',
        proposalName: 'Elizabeth',
        proposall: '619507ffe4f1083be4a20728',
        policy: [
          {
            name: 'BOP',

            image: '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            status: 'In Progress',
            premium: 1000,
          },
        ],
        statis: ['In Progress'],
        state: 'NL',
        dateCreated: '12/15/2019',
        status: 'Issued',
        premium: [1000],
        createdBY: 'Eve Sample',
        carrier: 'Markel',
        downloadIcon:
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        clientName: 'Allen Margaret',
        proposalName: 'Margaret',
        proposall: '6195104fe4f1083be4a20731',
        policy: [
          {
            name: 'BOP',

            image: '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            status: 'In Progress',
            premium: 1200,
          },
        ],
        statis: ['In Progress'],
        state: 'FL',
        dateCreated: '12/15/2019',
        status: 'Issued',
        premium: [1200],
        createdBY: 'John Sample',
        carrier: 'Markel',
        downloadIcon:
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        clientName: 'Gonzalez Sandra',
        proposalName: 'Sandra',
        proposall: '61950e94e4f1083be4a2072f',
        policy: [
          {
            name: 'BOP',

            image: '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            status: 'In Progress',
            premium: 1250,
          },
        ],
        statis: ['In Progress'],
        state: 'FL',
        dateCreated: '01/25/2020',
        status: 'DECLINED',
        premium: [1250],
        createdBY: 'Eve Sample',
        carrier: 'Markel',
        downloadIcon:
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        clientName: 'Robinson Sharon',
        proposalName: 'Sharon',
        proposall: '6194e1e3e4f1083be4a20725',
        policy: [
          {
            name: 'BOP',

            image: '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            status: 'In Progress',
            premium: 1025,
          },

          {
            name: 'GL',

            image: '/assets/road-runner/images/icons/GeneralLiability.png',
            status: 'In Progress',
            premium: 0,
          },

          {
            name: 'PL',

            image: '/assets/road-runner/images/icons/WorkersCompensation.png',
            status: 'Awaiting Bind',
            premium: 0,
          },
        ],
        statis: ['In Progress', 'In Progress', 'Awaiting Bind'],
        state: 'NY',
        dateCreated: '01/14/2020',
        status: 'Issued',
        premium: [1025, 0, 0],
        createdBY: 'David Sample',
        carrier: 'Markel',
        downloadIcon:
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        clientName: 'Carter Donald',
        proposalName: 'Donald',
        proposall: '619497e4e4f1083be4a2071f',
        policy: [
          {
            name: 'BOP',

            image: '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            status: 'In Progress',
            premium: 450,
          },

          {
            name: 'GL',

            image: '/assets/road-runner/images/icons/GeneralLiability.png',
            status: 'In Progress',
            premium: 0,
          },

          {
            name: 'PL',

            image: '/assets/road-runner/images/icons/WorkersCompensation.png',
            status: 'Awaiting Bind',
            premium: 0,
          },
        ],
        statis: ['In Progress', 'In Progress', 'Awaiting Bind'],
        state: 'AZ',
        dateCreated: '12/15/2019',
        status: 'Issued',
        premium: [450, 0, 0],
        createdBY: 'Eve Sample',
        carrier: 'Markel',
        downloadIcon:
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        clientName: 'White Thomas',
        proposalName: 'Thomas',
        proposall: '61949877e332f218255e6bd9',
        policy: [
          {
            name: 'BOP',

            image: '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            status: 'In Progress',
            premium: 1300,
          },

          {
            name: 'GL',

            image: '/assets/road-runner/images/icons/GeneralLiability.png',
            status: 'In Progress',
            premium: 0,
          },

          {
            name: 'PL',

            image: '/assets/road-runner/images/icons/WorkersCompensation.png',
            status: 'Awaiting Bind',
            premium: 0,
          },
        ],
        statis: ['In Progress', 'In Progress', 'Awaiting Bind'],
        state: 'NL',
        dateCreated: '12/15/2019',
        status: '[Issued]',
        premium: [1300, 0, 0],
        createdBY: 'Eve Sample',
        carrier: 'Markel',
        downloadIcon:
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        clientName: 'Martinez Kimberly',
        proposalName: 'Kimberly',
        proposall: '619497e4e4f1083be4a2071f',
        policy: [
          {
            name: 'BOP',

            image: '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            status: 'In Progress',
            premium: 100,
          },

          {
            name: 'GL',

            image: '/assets/road-runner/images/icons/GeneralLiability.png',
            status: 'In Progress',
            premium: 200,
          },

          {
            name: 'PL',

            image: '/assets/road-runner/images/icons/WorkersCompensation.png',
            status: 'Awaiting Bind',
            premium: 0,
          },
        ],
        statis: ['In Progress', 'In Progress', 'Awaiting Bind'],
        state: 'FL',
        dateCreated: '12/15/2019',
        status: 'Issued',
        premium: [100, 200, 0],
        createdBY: 'John Sample',
        carrier: 'Markel',
        downloadIcon:
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
    ];
    this.loading = false;
    this.activequotes.forEach(
      (customer) => (customer.dateCreated = new Date(customer.dateCreated))
    );
    this.colsForCsv = [
      { field: 'clientName', header: 'Client Name' },
      { field: 'proposalName', header: 'Proposal Name' },
      { field: 'proposall', header: 'Proposal Id' },
      { field: 'policy', header: 'Business Line' },
      { field: 'dateCreated', header: 'DateCreated' },
      { field: 'state', header: 'State' },
    ];

    this.exportColumns = this.colsForCsv.map((col) => ({
      // title: col.header,
      // dataKey: col.field
    }));
  }

  customSort(event: SortEvent) {
    // console.log(typeof event);

    let a = event.data.sort((a, b) => {
      let value1 = a[event.field];
      let value2 = b[event.field];
      let result = null;

      if (value1 == null && value2 != null) result = -1;
      else if (value1 != null && value2 == null) result = 1;
      else if (value1 == null && value2 == null) result = 0;
      else if (typeof value1 === 'string' && typeof value2 === 'string')
        result = value1.localeCompare(value2);
      else result = value1 < value2 ? -1 : value1 > value2 ? 1 : 0;
      console.log(event.order * result);

      return event.order * result;
    });
    console.log(a);
  }
  columnsForActivePdf = [
    { title: 'clientName', dataKey: 'clientName' },
    { title: 'proposalName', dataKey: 'proposalName' },
    { title: 'Proposal Id', dataKey: 'proposall' },
    { title: 'state', dataKey: 'state' },
    { title: 'date entered', dataKey: 'dateCreated' },
    { title: 'policy', dataKey: 'policy.name' },
    { title: 'status', dataKey: 'status' },
    { title: 'premium', dataKey: 'premium' },
    { title: 'dateCreated', dataKey: 'dateCreated' },
    { title: 'dateCreated', dataKey: 'dateCreated' },
    // { title: "downloadIcon", dataKey: "downloadIcon" },
  ];

  exportPdfActive() {
    const doc = new jsPDF('p', 'pt');
    console.log(this.selectedProducts);

    autoTable(doc, {
      columns: this.columnsForActivePdf,
      body: this.selectedProducts.length
        ? this.selectedProducts
        : this.activequotes,
      //   didDrawPage: (dataArg) => {
      //    doc.text('Sales', dataArg.settings.margin.left, 10);
      //   }
    });
    doc.save('sales.pdf');
  }
  exportAsXLSX(): void {
    this.excelService.exportAsExcelFile(this.customers, 'myExcelFile');
  }
  exportAsXLSXActive() {
    this.excelService.exportAsExcelFile(
      this.selectedProducts.length ? this.selectedProducts : this.activequotes,
      'myExcelFile'
    );
  }
  csvExport() {
    this.excelService.exportAsExcelFile(
      this.expiredQuotes__data,
      'myExcelFile'
    );
  }
  showme: boolean = true;
  counter = 1;
  quotesTableMobviewDropbtn(event) {
    var mouseEvent = $(event.target);
    console.log(event.target);

    var hidebyClick = mouseEvent.parent().prevAll();
    var hidebyClick1 = mouseEvent.prevAll();
    hidebyClick.css('display', 'none');
    hidebyClick1.css('display', 'none');
    // mouseEvent.css("margin-botton","20px")

    if (this.counter % 2 === 0) {
      hidebyClick.css('display', 'block');
      hidebyClick1.css('display', 'block');
      mouseEvent.parent().css('margin-top', '1px');
      this.counter += 1;
    } else {
      hidebyClick.css('display', 'none');
      hidebyClick1.css('display', 'none');
      mouseEvent.parent().css('margin-top', '-10px');
      this.counter += 1;
    }
  }
  // expiedquotes
  clear(table: Table) {
    table.clear();
    if (this.inpDataClientName.length || this.inpDataClientId.length) {
      table.filterGlobal('', 'contains');
      this.inpDataClientName = '';
      this.inpDataClientId = '';
    }
  }

  exportCSV() {
    if (this.selectedProducts.length) this.dataTable.exportCSV({ selectionOnly: true });
    else this.dataTable.exportCSV();
  }
}
