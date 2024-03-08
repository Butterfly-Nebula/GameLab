main();

const vsSource = `
    #version 330 core

    attribute vec4 = aVertexPosition;
    uniform mat4 uModelViewMatrix;
    uniform mat4 uProjectionMatrix;
      
    void main()
    {
      gl_Position = uProjectionMatrix * uModelViewMatrix * aVertexPosition;
    }
`;

function main()
{
  const canvas = document.querySelector("#glcanvas");
  const gl = canvas.getContext("webgl");

  if (gl === null)
  {
    alert(
      "Unable to initialize WebGL. Your browser does not support it. :<",
    );
    return;
  }

  let x = 0;
  x += 5;

  document.addEventListener('keydown', function(event)
  {
    if (event.keyCode == 37)
    {
      gl.clearColor(1.0, 0.0, 1.0, 1.0);
      gl.clear(gl.COLOR_BUFFER_BIT);
      document.getElementById('id').innerHTML = "The value of X is: " + x;
    }
    else if(event.keyCode == 39)
    {
      gl.clearColor(1.0, 1.0, 0.0, 1.0);
      gl.clear(gl.COLOR_BUFFER_BIT);
      document.getElementById('id').innerHTML = "The value of 2*X is: " + (x * 2);
    }
  });

}
