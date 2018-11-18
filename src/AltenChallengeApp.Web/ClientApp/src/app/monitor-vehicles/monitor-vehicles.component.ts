import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HubConnection, HubConnectionBuilder } from '@aspnet/signalr';

@Component({
  selector: 'app-monitor-vehicles',
  templateUrl: './monitor-vehicles.component.html'
})
export class MonitorVehiclesComponent implements OnInit {

  public vehicles: Vehicle[];
  public hubConnection: HubConnection;
  public filtered: boolean = false;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Vehicle[]>(baseUrl + 'api/vehicles').subscribe(result => {
      this.vehicles = result;
    }, error => console.error(error));
  }



  ngOnInit(): void {
    let builder = new HubConnectionBuilder();

    // as per setup in the startup.cs
    this.hubConnection = builder.withUrl('/pingHub').build();

    // message coming from the server
    this.hubConnection.on("Ping", (result) => {
      if (!this.filtered) {
        this.vehicles = result as Vehicle[];
      }
    });

    // starting the connection
    this.hubConnection.start();
  }

  // search vehicles by customer
  getVehiclesByCustomer(customerName: String) {
    this.filtered = true;
    this.vehicles = this.vehicles.filter(x => x.customerName === customerName);
  }

  // search vehicles by status
  getVehiclesByStatus(vehicleStatus: Boolean) {
    this.filtered = true;
    this.vehicles = this.vehicles.filter(x => x.status === vehicleStatus);
  }

  clearFilters() {
    this.filtered = false;
  }
}

interface Vehicle {
  id: string;
  registrationNumber: string;
  status: boolean;
  customerName: string;
  customerAddress: string;
  customerZipCode: string;
  customerCity: string;
  customerCountry: string;
  customerId: string;
}
