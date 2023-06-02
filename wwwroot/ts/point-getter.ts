import { Point } from "./point.js";
import Konva from "konva/lib/Core";
import {Circle} from "konva/lib/shapes/Circle"

export class PointGetter{
    private points: Point[];
    private point: Point;

    constructor(xCoord, yCoord, radius){
        this.point.xCoord = +xCoord;
        this.point.yCoord = +yCoord;
        this.point.radius = +radius;
    }

}
var stage = new Konva.Stage({
    container: 'container',   // id of container <div>
    width: 500,
    height: 500
  });

var layer = new Konva.Layer();

// create our shape
var circle = new Circle({
  x: stage.width() / 2,
  y: stage.height() / 2,
  radius: 70,
  fill: 'red',
  stroke: 'black',
  strokeWidth: 4
});

// add the shape to the layer
layer.add(circle);

// add the layer to the stage
stage.add(layer);

// draw the image
layer.draw();
// var xCoord = (<HTMLInputElement>document.getElementById("xCoord")).value;
// var yCoord = (<HTMLInputElement>document.getElementById("yCoord")).value;
// var radius = (<HTMLInputElement>document.getElementById("radius")).value;
// console.log(xCoord);
// console.log(yCoord);
// console.log(radius);

// var p = new PointGetter(xCoord, yCoord, radius);