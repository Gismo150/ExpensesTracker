import { Component, OnInit } from '@angular/core';
import { ThemeService } from 'ng2-charts';
import { ChartOptions } from 'chart.js';

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

  chartFontColor = 'rgba(255,255,255,0.6)';
  chartOptions: ChartOptions = {
    responsive: true,
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


  /*Dummy Data */
  chartData = [
    { data: [330, 600, 260, 700], label: 'Antje' },
    { data: [120, 455, 100, 340], label: 'Daniel' },
  ];
  /*...*/
  chartLabels = ['January', 'February', 'March', 'April'];

  onChartClick(event) {
    console.log(event);
  }


  constructor() { }

  ngOnInit() {
    //this.themeService.setColorschemesOptions(this.chartTheme);
  }

}
