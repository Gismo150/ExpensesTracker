import { Component, OnInit, ViewChild } from '@angular/core';
import { ThemeService, BaseChartDirective } from 'ng2-charts';
import { ChartOptions } from 'chart.js';
import { LabelOptions } from '@angular/material/core';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})

export class DashboardComponent implements OnInit {
  /*chartTheme: ChartOptions = { // https://valor-software.com/ng2-charts/ see #Dynamic Theming
    legend: {
      labels: { fontColor: 'white' }
    },
    scales: {
      xAxes: [{
        ticks: { fontColor: 'white' },
        gridLines: { color: 'rgba(255,255,255,1)', zeroLineColor: 'white' }
      }],
      yAxes: [{
        ticks: { fontColor: 'white' },
        gridLines: { color: 'rgba(255,255,255,1)', zeroLineColor: 'white' },

      }]
    }
  };*/

 /* @ViewChild(BaseChartDirective, {static: false})
  public chart: BaseChartDirective;*/

  chartFontColor = 'rgba(255,255,255,0.6)';
  lineChartOptions: ChartOptions = {
    responsive: true,
    layout: {
      padding: {
      left: 0,
      right: 0,
      top: 0,
      bottom: 35
      },
    },
    legend: {
      labels: { fontColor: this.chartFontColor}
    },
    scales: {
      xAxes: [{
        ticks: { fontColor: this.chartFontColor, padding: 10},
        gridLines: { color: 'rgba(255,255,255,0.2)', zeroLineColor: 'white' }
      }],
      yAxes: [{
        ticks: { fontColor: this.chartFontColor,  padding: 10},
        gridLines: { color: 'rgba(255,255,255,0.2)', zeroLineColor: 'white', },
       // scaleLabel: { labelString: 'Euro', display: true, fontColor: this.chartFontColor }
      }]
    }
  };

  doughnutChartOptions: ChartOptions = {
    responsive: true,
    layout: {
      padding: {
        left: 0,
        right: 0,
        top: 0,
        bottom: 40
      }
    },
    legend: {
      labels: { fontColor: this.chartFontColor}
    }
  };


  /*Dummy Data */
  lineChartData = [
    { data: [330, 600, 260, 700], label: 'Antje' },
    { data: [120, 455, 100, 340], label: 'Daniel' },
  ];
  doughnutChartData = [
    { data: [330, 600] },
  ];
  /*...*/
  lineChartLabelsMonthlyExpenses = ['January', 'February', 'March', 'April'];
  doughnutChartLabels = ['Antje', 'Daniel'];

  onChartClick(event) {
    console.log(event);
    //this.chart.chart.resize();
  }




  constructor() { }

  ngOnInit() {
    //this.themeService.setColorschemesOptions(this.chartTheme);
  }

}
