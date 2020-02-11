import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DashboardRoutingModule } from './dashboard-routing.module';
import { DashboardComponent } from './dashboard.component';
import { AngularMaterialModule } from 'src/app/helpers/angular-material.module';
import { ChartsModule } from 'ng2-charts';



@NgModule({
  declarations: [DashboardComponent],
  imports: [
    AngularMaterialModule,
    DashboardRoutingModule,
    CommonModule,
    ChartsModule,
  ]
})
export class DashboardModule { }
