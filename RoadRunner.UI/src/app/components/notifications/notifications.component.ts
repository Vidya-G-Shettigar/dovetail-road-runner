import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-notifications',
  templateUrl: './notifications.component.html',
  styleUrls: ['./notifications.component.css'],
})
export class NotificationsComponent implements OnInit {
  private deleteErrorMsg = {
    label: "Sorry, but you can't delete the selected subject.",
    msg: 'This is because notice of cancellation, pending cancellation and endorsement must be opened/clicked before it can be deleted.',
  };
  private readErrorMsg = {
    label: "Sorry, but you can't mark selected as read.",
    msg: 'This is because notice of cancellation, pending cancellation and endorsement must be opened/clicked before it can be marked as read.',
  };
  private notificationList = [
    {
      id: 1,
      subject: 'Renewal offered - policy PAC98765432 for Ikes Grocery Store',
      date: new Date('02/12/2020'),
      read: false,
      showIcon: false,
    },
    {
      id: 2,
      subject: 'Pending cancellation - policy PAC98765432 for Gamecock Shop',
      date: new Date('02/11/2020'),
      read: false,
      showIcon: true,
    },
    {
      id: 3,
      subject: 'Notice of cancellation - policy PAC98765432 for Pitstop Market',
      date: new Date('02/10/2020'),
      read: false,
      showIcon: true,
    },
    {
      id: 4,
      subject: 'Reinstatement - policy PAC98765432 for Pachilis Store',
      date: new Date('02/01/2020'),
      read: true,
      showIcon: false,
    },
    {
      id: 5,
      subject:
        'This policy has been endorsed - policy PAC98765432 for Thistle Market',
      date: new Date('02/01/2020'),
      read: true,
      showIcon: false,
    },
    {
      id: 6,
      subject:
        'Quote available for referral - policy PAC98765432 for Brady Cafes',
      date: new Date('01/25/2020'),
      read: true,
      showIcon: false,
    },
    {
      id: 7,
      subject:
        'Referral approved by underwriter - policy PAC98765432 for Kwong Industries',
      date: new Date('01/25/2020'),
      read: true,
      showIcon: false,
    },
    {
      id: 8,
      subject:
        'Cancellation rescission - policy PAC98765432 for Komene Gardens',
      date: new Date('01/11/2020'),
      read: true,
      showIcon: false,
    },
    {
      id: 9,
      subject: 'Renewal offered - policy PAC98765432 for Lange Homes',
      date: new Date('12/23/2019'),
      read: true,
      showIcon: false,
    },
    {
      id: 10,
      subject:
        'Referral declined by underwriter - policy PAC98765432 for Thomsan Storage',
      date: new Date('12/14/2019'),
      read: true,
      showIcon: false,
    },
  ];

  public errorHeader: string = '';
  public errorBody: string = '';
  public errorPopup: boolean = false;
  public loading: boolean = true;
  public notificationTableData: any[] = [];
  public selectedFilter: string = 'all';
  public selectedSubjects: any[] = [];
  public statuses = [
    { label: 'All', value: 'all' },
    { label: 'Read', value: 'read' },
    { label: 'Unread', value: 'unread' },
  ];

  constructor() {}

  ngOnInit(): void {
    this.loading = false;
    this.notificationTableData = this.notificationList;
  }

  // Function to delete selected subject
  deleteSelected() {
    if (this.filterSubjects().length) {
      this.errorPopup = true;
      this.errorHeader = this.deleteErrorMsg.label;
      this.errorBody = this.deleteErrorMsg.msg;
    } else this.errorPopup = false;
  }

  // Function to mark selected subject as unread
  markUnread() {
    this.selectedSubjects.forEach((subject) => {
      this.notificationTableData.filter((value) => {
        if (value.id === subject.id && value.read) value.read = !value.read;
      });
    });
  }

  // Function to mark selected subject as read
  markRead() {
    if (this.filterSubjects().length) {
      this.errorPopup = true;
      this.errorHeader = this.readErrorMsg.label;
      this.errorBody = this.readErrorMsg.msg;
    } else {
      this.selectedSubjects.forEach((subject) => {
        this.notificationTableData.filter((value) => {
          if (value.id === subject.id && !value.read) value.read = !value.read;
        });
      });
    }
  }

  // Function to close the error message
  onCloseError() {
    this.errorPopup = false;
  }

  // Function to return filtered subject
  filterSubjects() {
    return this.selectedSubjects.filter((value) => value.showIcon);
  }

  // Triggered on change of filter dropdown
  onFilter(event) {
    if (event === 'read')
      this.notificationTableData = this.notificationList.filter(
        (value) => value.read
      );
    else if (event === 'unread')
      this.notificationTableData = this.notificationList.filter(
        (value) => !value.read
      );
    else this.notificationTableData = this.notificationList;
  }
}
