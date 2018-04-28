/**
* Theme: Minton Admin Template
* Author: Coderthemes
* Component: Sparkline Chart
*
*/
!function ($) {
    "use strict";

    var Dashboard = function () { };

    //creates Stacked chart
    Dashboard.prototype.Createlinechart = function (element, data, xkey, ykeys, labels, lineColors) {
        Morris.Line({
            element: element,
            data: data,
            xkey: xkey,
            ykeys: ykeys,
            labels: labels,
            lineWidth: '6px',
            parseTime: false,
            hideHover: true,
            stacked: true
        });
    },
    //creates Stacked chart
    Dashboard.prototype.createStackedChart = function (element, data, xkey, ykeys, labels, lineColors) {
        Morris.Bar({
            element: element,
            data: data,
            xkey: xkey,
            ykeys: ykeys,
            stacked: true,
            labels: labels,
            hideHover: 'auto',
            barSizeRatio: 0.5,
            resize: true, //defaulted to true
            gridLineColor: '#eeeeee',
            lineWidth: '6px',

        });
    },
    //creates Donut chart
    Dashboard.prototype.createDonutChart = function (element, data, colors) {
        Morris.Donut({
            element: element,
            data: data,
            resize: true, //defaulted to true
            colors: colors
        });
        
    },
    

    Dashboard.prototype.init = function () {
        
        //creating Stacked chart
        var $stckedData1 = [
            { y: 'Jenuary', a: s  },
            { y: 'Febrary'},
            { y: 'March', },
            { y: 'April', },
            { y: 'May', },
            { y: 'June'},
            { y: 'July', },
            { y: 'August',},
            { y: 'September',},
            { y: 'October', },
            { y: 'November',},
            { y: 'December', }
        ];  
        var s = $.ajax({
            url: "/Home/acti?appId=BOP17_OI&initialDate=2018-04-01&endDate=2018-04-25",
            success: function (data) {
                debugger
                var o = 0;
                var i;
                for (i = 0; i < data.cancellation.length; i++) {
                    o += data.cancellation[i].Cantidad;
                }

                $("this.stckedData1").html($stckedData1[0].push = (o)) ;
                   
            },
            error: function (xhr) {
                debugger;
            },
            type: "GET",
            dataType: 'json',
            contentType: "application/json; charset=utf-8"
        })
        this.createStackedChart('dashboard-chart-1', $stckedData, 'y', ['a', 'b', 'c'], ['Series A', 'Series s', 'Series C'], ['#52bb56', '#f38280', '#ebeff2']);

        //creating Stacked chart
        var $stckedData = [
            { y: 'Jenuary', a: 70, b: 12 },
            { y: 'Febrary', a: 18 },
            { y: 'March', a: 123 },
            { y: 'April', a: 11 },
            { y: 'May', a: 112 },
            { y: 'June', a: 13 },
            { y: 'July', a: 13 },
            { y: 'August', a: 14 },
            { y: 'September', a: 16 },
            { y: 'October', a: 17 },
            { y: 'November', a: 18 },
            { y: 'December', a: 19 }
        ];
        this.Createlinechart('dashboard-chart-2', $stckedData, 'y', ['a', 'b', 'c'], ['Series A', 'Series s', 'Series C'], ['#52bb56', '#f38280', '#ebeff2']);


        //creating donut chart
        var $donutData = [
                { label: "BOP Help", value: 18 },


        ];
        this.createDonutChart('morris-donut-example', $donutData, ['#f1b53d', '#ebeff2', '#03a9f3']);

    },
    //init
    $.Dashboard = new Dashboard, $.Dashboard.Constructor = Dashboard
}(window.jQuery),

//initializing
function ($) {
    "use strict";
    $.Dashboard.init();
}(window.jQuery);