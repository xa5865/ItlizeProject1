 var loadFile = function (event) {
      var output = document.getElementById('pic1');
     output.src = URL.createObjectURL(event.target.files[0]);
}
