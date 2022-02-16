import { Component, OnInit } from '@angular/core';
import { SortEvent } from 'primeng/api/sortevent';
import jsPDF from 'jspdf';
import autoTable from 'jspdf-autotable';
import { ExcelService } from 'src/app/services/excel.service';
import { Table } from 'primeng/table/table';
declare var $:any;

@Component({
  selector: 'app-quotestable',
  templateUrl: './quotestable.component.html',
  styleUrls: ['./quotestable.component.css'],
})
export class QuotestableComponent implements OnInit {
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
  selectedProducts:any[]=[];
  selectedProductsExpired:any=[]
  colsForCsvExpired:any[];
  inpData='';
  constructor(private excelService: ExcelService) {}

  expiredQuotes__data: any;
  ngOnInit() {

    this.statuses = [
      { label: '6', value: '6' },
      { label: '12', value: '12' },
      { label: '18', value: '18' },
      { label: '24', value: '24' },
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
    //  ------my polic start
    this.expiredQuotes__data = [
      {
        "clientName": '',
        "proposalName": '',
        "proposall": '61952368e4f1083be4a2073b',
        "policy": [
          {
            "name": 'BOP',

            "image": '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            "premium":24
          },
        ],
        "state": 'FL',
        "dateCreated": '01/25/2020',
        "status": 'DECLINED',
        "premium":[24],
        "createdBY": 'Eve Sample',
        "downloadIcon":
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        "clientName": 'Anderson Christopher',
        "proposalName": 'Christopher',
        "proposall": '61950df0e4f1083be4a2072d',
        "policy": [
          {
            "name": 'BOP',

            "image": '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            "premium":1
          },
        ],
        "state": 'NY',
        "dateCreated": '01/14/2020',
        "status": 'Issued',
        "premium": [1],
        "createdBY": 'David Sample',
        "downloadIcon":
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        "clientName": 'Williams Richard',
        "proposalName": 'Richard',
        "proposall": '6195134fe4f1083be4a20736',
        "policy": [
          {
            "name": 'BOP',

            "image": '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            "premium":800
          },

          {
            "name": 'GL',

            "image": '/assets/road-runner/images/icons/GeneralLiability.png',
            "premium":500
          },

          {
            "name": 'PL',

            "image": '/assets/road-runner/images/icons/WorkersCompensation.png',
            "premium":600
          },
        ],
        "state": 'AZ',
        "dateCreated": '12/15/2019',
        "status": 'Issued',
        "premium": [800,500,600],
        "createdBY": 'Eve Sample',
        "downloadIcon":
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        "clientName": 'Walker Elizabeth',
        "proposalName": 'Walker Elizabeth',
        "proposall": '619507ffe4f1083be4a20728',
        "policy": [
          {
            "name": 'BOP',

            "image": '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            "premium":7
          },
        ],
        "state": 'NL',
        "dateCreated": '12/15/2019',
        "status": 'Issued',
        "premium": [7],
        "createdBY": 'Eve Sample',
        "downloadIcon":
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        "clientName": 'Allen Margaret',
        "proposalName": 'Margaret',
        "proposall": '6195104fe4f1083be4a20731',
        "policy": [
          {
            "name": 'BOP',

            "image": '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            "premium":8
          },
        ],
        "state": 'FL',
        "dateCreated": '12/15/2019',
        "status": 'Issued',
        "premium": [8],
        "createdBY": 'John Sample',
        "downloadIcon":
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        "clientName": 'Gonzalez Sandra',
        "proposalName": 'Sandra',
        "proposall": '61950e94e4f1083be4a2072f',
        "policy": [
          {
            "name": 'BOP',

            "image": '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            "premium":24
          },
        ],
        "state": 'FL',
        "dateCreated": '01/25/2020',
        "status": 'DECLINED',
        "premium": [24],
        "createdBY": 'Eve Sample',
        "downloadIcon":
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        "clientName": 'Robinson Sharon',
        "proposalName": 'Sharon',
        "proposall": '6194e1e3e4f1083be4a20725',
        "policy": [
          {
            "name": 'BOP',
            "image": '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            "premium":1005
          },
          {
            "name": 'GL',
            "image": '/assets/road-runner/images/icons/GeneralLiability.png',
            "premium":201
          },
          {
            "name": 'PL',
            "image": '/assets/road-runner/images/icons/WorkersCompensation.png',
            "premium":300
          },
        ],
        "state": 'NY',
        "dateCreated": '01/14/2020',
        "status": 'Issued',
        "premium": [1005,201,300],
        "createdBY": 'David Sample',
        "downloadIcon":
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        "clientName": 'Carter Donald',
        "proposalName": 'Donald',
        "proposall": '619497e4e4f1083be4a2071f',
        "policy": [
          {
            "name": 'BOP',

            "image": '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            "premium":0
          },
        ],
        "state": 'AZ',
        "dateCreated": '12/15/2019',
        "status": 'Issued',
        "premium": [0],
        "createdBY": 'Eve Sample',
        "downloadIcon":
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        "clientName": 'Martinez Kimberly',
        "proposalName": 'Kimberly',
        "proposall": '61949877e332f218255e6bd9',
        "policy": [
          {
            "name": 'BOP',

            "image": '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            "premium":8
          },

          {
            "name": 'GL',

            "image": '/assets/road-runner/images/icons/GeneralLiability.png',
            "premium":0
          },

          {
            "name": 'PL',

            "image": '/assets/road-runner/images/icons/WorkersCompensation.png',
            "premium":0
          },
        ],
        "state": 'FL',
        "dateCreated": '12/15/2019',
        "status": 'Issued',
        "premium": [8,0,0],
        "createdBY": 'John Sample',
        "downloadIcon":
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
    ];
    this.activequotes = [ 
      {
        "clientName": '',
        "proposalName": '',
        "proposall": '619497e4e4f1083be4a2071f',
        "policy": [
          {
            "name": 'BOP',

            "image": '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            "status":'In Progress',
            "premium":1500
          },
          {
            "name": 'GL',

            "image": '/assets/road-runner/images/icons/GeneralLiability.png',
            "status":'In Progress',
            "premium":0
          },
          {
            "name": 'PL',

            "image": '/assets/road-runner/images/icons/WorkersCompensation.png',
            "status":'Awaiting Bind',
            "premium":0
          },
        ],
        "statis": ['In Progress', 'In Progress', 'Awaiting Bind'],
        "state": 'FL',
        "dateCreated": '01/25/2020',
        "effectiveDate":'02/12/2020',
        "lastEdited":'04/18/2021',
        "status": 'DECLINED',
        "premium": [1500,0,0],
        "createdBY": 'Eve Sample',
        "downloadIcon":
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        "clientName": 'Anderson Christopher',
        "proposalName": 'Christopher',
        "proposall": '61949877e332f218255e6bd9',
        "policy": [
          {
            "name": 'BOP',

            "image": '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            "status":'In Progress',
            "premium": 900,
          },
        ],
        "statis": ['In Progress'],

        "state": 'NY',
        "dateCreated": '01/14/2020',
        "effectiveDate":'02/12/2020',
        "lastEdited":'02/10/2021',
        "status": 'Issued',
        "premium": [900],
        "createdBY": 'David Sample',
        "downloadIcon":
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        "clientName": 'Williams Richard',
        "proposalName": 'Richard',
        "proposall": '6194974de332f218255e6bd5',
        "policy": [
          {
            "name": 'BOP',

            "image": '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            "status":'In Progress',
            "premium": 200,
          },
        ],
        "statis": ['In Progress'],
        "state": 'AZ',
        "dateCreated": '12/15/2019',
        "effectiveDate":'01/20/2019',
        "lastEdited":'03/10/2021',
        "status": 'Issued',
        "premium": [200],
        "createdBY": 'Eve Sample',
        "downloadIcon":
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        "clientName": 'Walker Elizabeth',
        "proposalName": 'Elizabeth',
        "proposall": '619496b9e332f218255e6bd2',
        "policy": [
          {
            "name": 'BOP',

            "image": '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            "status":'In Progress',
            "premium": 1000
          },
        ],
        "statis": ['In Progress'],
        "state": 'NL',
        "dateCreated": '12/15/2019',
        "effectiveDate":'12/26/2019',
        "lastEdited":'06/17/2021',
        "status": 'Issued',
        "premium": [1000],
        "createdBY": 'Eve Sample',
        "downloadIcon":
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        "clientName": 'Allen Margaret',
        "proposalName": 'Margaret',
        "proposall": '6194961fe4f1083be4a20717',
        "policy": [
          {
            "name": 'BOP',

            "image": '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            "status":'In Progress',
            "premium": 1200
          },
        ],
        "statis": ['In Progress'],
        "state": 'FL',
        "dateCreated": '12/15/2019',
        "effectiveDate":'12/21/2019',
        "lastEdited":'07/10/2021',
        "status": 'Issued',
        "premium": [1200],
        "createdBY": 'John Sample',
        "downloadIcon":
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        "clientName": 'Gonzalez Sandra',
        "proposalName": 'Sandra',
        "proposall": '61949561e332f218255e6bce',
        "policy": [
          {
            "name": 'BOP',

            "image": '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            "status":'In Progress',
            "premium": 1250
          },
        ],
        "statis": ['In Progress'],
        "state": 'FL',
        "dateCreated": '01/25/2020',
        "effectiveDate":'02/01/2020',
        "lastEdited":'11/28/2021',
        "status": 'DECLINED',
        "premium": [1250],
        "createdBY": 'Eve Sample',
        "downloadIcon":
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        "clientName": 'Robinson Sharon',
        "proposalName": 'Sharon',
        "proposall": '619494c9e332f218255e6bcb',
        "policy": [
          {
            "name": 'BOP',

            "image": '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            "status":'In Progress',
            "premium": [1025]
          },

          {
            "name": 'GL',

            "image": '/assets/road-runner/images/icons/GeneralLiability.png',
            "status":'In Progress',
            "premium": 0
          },

          {
            "name": 'PL',

            "image": '/assets/road-runner/images/icons/WorkersCompensation.png',
            "status":'Awaiting Bind',
            "premium": 0
          },
        ],
        "statis": ['In Progress', 'In Progress', 'Awaiting Bind'],
        "state": 'NY',
        "dateCreated": '01/14/2020',
        "effectiveDate":'01/28/2020',
        "lastEdited":'12/10/2021',
        "status": 'Issued',
        "premium": [1025,0,0],
        "createdBY": 'David Sample',
        "downloadIcon":
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        "clientName": 'Carter Donald',
        "proposalName": 'Donald',
        "proposall": '61949434e4f1083be4a2070f',
        "policy": [
          {
            "name": 'BOP',

            "image": '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            "status":'In Progress',
            "premium": 450
          },

          {
            "name": 'GL',

            "image": '/assets/road-runner/images/icons/GeneralLiability.png',
            "status":'In Progress',
            "premium": 0
          },

          {
            "name": 'PL',

            "image": '/assets/road-runner/images/icons/WorkersCompensation.png',
         "status":'Awaiting Bind',
         "premium": 0
          },
        ],
        "statis": ['In Progress', 'In Progress', 'Awaiting Bind'],
        "state": 'AZ',
        "dateCreated": '12/15/2019',
        "effectiveDate":'12/25/2019',
        "lastEdited":'01/11/2021',
        "status": 'Issued',
        "premium": [450,0,0],
        "createdBY": 'Eve Sample',
        "downloadIcon":
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        "clientName": 'White Thomas',
        "proposalName": 'Thomas',
        "proposall": '6194939fe4f1083be4a2070c',
        "policy": [
          {
            "name": 'BOP',

            "image": '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            "status":'In Progress',
            "premium": 1300
          },

          {
            "name": 'GL',

            "image": '/assets/road-runner/images/icons/GeneralLiability.png',
            "status":'In Progress',
            "premium": 0
          },

          {
            "name": 'PL',

            "image": '/assets/road-runner/images/icons/WorkersCompensation.png',
          "status":'Awaiting Bind',
          "premium": 0
          },
        ],
       "statis": ['In Progress', 'In Progress', 'Awaiting Bind'],
        "state": 'NL',
        "dateCreated": '12/15/2019',
        "effectiveDate":'12/20/2019',
        "lastEdited":'10/25/2021',
       "status": '[Issued]',
       "premium": [1300,0,0],
        "createdBY": 'Eve Sample',
        "downloadIcon":
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
      {
        "clientName": 'Martinez Kimberly',
        "proposalName": 'Kimberly',
        "proposall": '61949326e4f1083be4a20708',
        "policy": [
          {
            "name": 'BOP',

            "image": '/assets/road-runner/images/icons/BusinessOwnersPolicy.png',
            "status":'In Progress',
            "premium": 100
          },

          {
            "name": 'GL',

            "image": '/assets/road-runner/images/icons/GeneralLiability.png',
            "status":'In Progress',
            "premium": 200
          },

          {
            "name": 'PL',

            "image": '/assets/road-runner/images/icons/WorkersCompensation.png',
         "status":'Awaiting Bind',
         "premium": 0
          },
        ],
        "statis": ['In Progress', 'In Progress', 'Awaiting Bind'],
        "state": 'FL',
        "dateCreated": '12/15/2019',
        "effectiveDate":'12/20/2019',
        "lastEdited":'03/26/2021',
        "status": 'Issued',
        "premium": [100,200,0],
        "createdBY": 'John Sample',
        "downloadIcon":
          '/onevictor/assets/dovetail/images/Download_Icon_Blue.svg',
      },
    ];
    this.statuses = [
      { label: '6 Months', value: 'Issued' },
      { label: '12 Months', value: 'DECLINED' },
      { label: '18 Months', value: 'DECLINED' },
      { label: '24 Months', value: 'DECLINED' },
    ];
    this.loading = false;
    this.activequotes.forEach(
      customer => (customer.dateCreated = new Date(customer.dateCreated),
      customer.lastEdited = new Date(customer.lastEdited),
      customer.effectiveDate = new Date(customer.effectiveDate))
    );
   
    

    this.colsForCsv = [
      { field: "clientName", header: "Client Name" },
      { field: "proposalName", header: "Proposal Name" },
      { field: "proposall", header: "Proposal Id" },
      { field: "policy", header: "Business Line" },
      { field: "dateCreated", header: "DateCreated" },
      { field: "state", header: "State" },
    ];
    this.colsForCsvExpired=[
      { field: "clientName", header: "Client Name" },
      { field: "proposalName", header: "Proposal Name" },
      { field: "proposall", header: "Proposal Id" },
      { field: "policy[name]", header: "Business Line" },
      { field: "state", header: "State" },
      {field:"dateCreated", header:"Last Edited"},
      {field:"premium", header:"Premium"},
    ]
    this.exportColumns = this.colsForCsv.map(col => ({
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
  columnsForExpiredPdf = [
    { title: 'clientName', dataKey: 'clientName' },
    { title: 'proposalName', dataKey: 'proposalName' },
    { title: 'Proposal Id', dataKey: 'proposall' },
    { title: 'policy', dataKey: 'policy.name' },
    { title: 'state', dataKey: 'state' },
    { title: 'Last Edited', dataKey: 'dateCreated' },
    { title: 'premium', dataKey: 'premium' },
    // { title: "downloadIcon", dataKey: "downloadIcon" },
  ];
  exportPdfActive() {
    const doc = new jsPDF('p', 'pt');
console.log(this.selectedProducts);

    autoTable(doc, {
      columns: this.columnsForActivePdf,
      body: this.selectedProducts.length?this.selectedProducts:this.activequotes,
      //   didDrawPage: (dataArg) => {
      //    doc.text('Sales', dataArg.settings.margin.left, 10);
      //   }
    });
    doc.save('sales.pdf');
  }
  exportPdfExpired() {
    const doc = new jsPDF('p', 'pt');
console.log(this.selectedProducts);

    autoTable(doc, {
      columns: this.columnsForExpiredPdf,
      body: this.selectedProductsExpired.length?this.selectedProductsExpired:this.expiredQuotes__data,
      //   didDrawPage: (dataArg) => {
      //    doc.text('Sales', dataArg.settings.margin.left, 10);
      //   }
    });
    doc.save('sales.pdf');
  }
  exportAsXLSX(): void {
    this.excelService.exportAsExcelFile(this.customers, 'myExcelFile');
  }


  exportAsXLSXExpired() {
    this.excelService.exportAsExcelFile(this.selectedProductsExpired?this.selectedProductsExpired:this.expiredQuotes__data, 'myExcelFile');
  }
  exportAsXLSXActive(){
    this.excelService.exportAsExcelFile(this.selectedProducts.length?this.selectedProducts:this.activequotes, 'myExcelFile');
  }

  csvExport() {
    this.excelService.exportAsExcelFile(this.expiredQuotes__data, 'myExcelFile');
  }

  
  showme: boolean = true;
  counter=1;
  
  quotesTableMobviewDropbtn(event) {
    var mouseEvent=$(event.target);
    console.log(event.target);
    
    var hidebyClick=mouseEvent.parent().prevAll();
    var hidebyClick1=mouseEvent.prevAll();
    hidebyClick.css("display", "none");
    hidebyClick1.css("display", "none");
    // mouseEvent.css("margin-botton","20px")


    if(this.counter%2===0){
      hidebyClick.css("display", "block");
      hidebyClick1.css("display", "block"); 
      mouseEvent.parent().css('margin-top','1px')            
      this.counter+=1;
      }
      else{
        hidebyClick.css("display", "none");
        hidebyClick1.css("display", "none");   
        mouseEvent.parent().css('margin-top','-10px')     
        this.counter+=1;
      }
  }
    // expiedquotes
    clear(table: Table) {
      table.clear();
      if (this.inpData.length) {
         table.filterGlobal('','contains');
          this.inpData=''
         }
    }
    clearTheExpiredFilters(table: Table) {
      table.clear();
    }
}
