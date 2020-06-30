// set in function of the last point created
var myMap = L.map("myMap").setView([47.0833, 2.4], 5);

// jeremy31
// token : pk.eyJ1IjoiamVyZW15MzEiLCJhIjoiY2tjMXYyZ3kwMXIzcTJ5bmF2c3BrMmF4ZSJ9.p6TFvLpLMqTvsEczwsSJGA

L.tileLayer('https://api.mapbox.com/styles/v1/{id}/tiles/{z}/{x}/{y}?access_token={accessToken}', {
    attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a> contributors, <a href="https://creativecommons.org/licenses/by-sa/2.0/">CC-BY-SA</a>, Imagery © <a href="https://www.mapbox.com/">Mapbox</a>',
    maxZoom: 18,
    id: 'mapbox/streets-v11',
    tileSize: 512,
    zoomOffset: -1,
    accessToken: 'pk.eyJ1IjoiamVyZW15MzEiLCJhIjoiY2tjMXYyZ3kwMXIzcTJ5bmF2c3BrMmF4ZSJ9.p6TFvLpLMqTvsEczwsSJGA'
}).addTo(myMap);

var parisPoint = document.getElementById("paris");

var parisOnce = false;
var toulouseOnce = false;
var lyonOnce = false;

displayPoints();

function displayCustomPoint(longitude, latitude) {
    var newPoint = L.marker([longitude, latitude]).addTo(myMap);
}

function displayPoints() {
    $(".paris").click(() => {

        if (!parisOnce) {
            var parisPoint = L.marker([48.8534, 2.3488]).addTo(myMap)
            parisPoint.bindPopup("Paris").openPopup();
            parisOnce = !parisOnce;
        }
    })
    
    $(".toulouse").click(() => {
        if (!toulouseOnce) {
            var toulousePoint = L.marker([43.6043, 1.4437]).addTo(myMap);
            toulousePoint.bindPopup("Toulouse").openPopup();
            toulouseOnce = !toulouseOnce;
        }
    })
    
    $(".lyon").click(() => {
        if (!lyonOnce) {
            var lyonPoint = L.marker([45.75, 4.85]).addTo(myMap);
            lyonPoint.bindPopup("Lyon").openPopup();
            lyonOnce = !lyonOnce;
        }
    })
}



