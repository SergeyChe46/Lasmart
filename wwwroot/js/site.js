var stage = new Konva.Stage({
    container: "container",
    width: window.innerWidth,
    height: window.innerHeight
  });
var layer = new Konva.Layer();

// create our shape
function newCircle(x, y, radius, color){
    var circle = new Konva.Circle({
        x: x,
        y: y,
        radius: radius,
        fill: color,
        stroke: 'black',
        strokeWidth: 4
      });
      layer.add(circle);
      stage.add(layer);
    }
layer.draw();

function addComment(){
    var comments = document.getElementById("comments");
    var input = document.createElement("input");
    input.name = "comments";
    comments.appendChild(document.createTextNode("Комментарий"));
    comments.appendChild(input);
    comments.appendChild(document.createElement("br"));
}