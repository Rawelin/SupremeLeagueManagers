Dokumentacja Biblioteki:



https://www.jqueryscript.net/loading/Fullscreen-Loading-Modal-Indicator-Plugin-For-jQuery-loadingModal.html

Najwa¿niejsze informacje:
loadingModal is a simple yet customizable jQuery loading indicator plugin which displays a fullscreen loading modal / overlay with more than 10 CSS3 powered loading spinners. Ideal for creating an use-friendly 'busy' loading screen over a specific element that is typically being called via AJAX requests.

Loading spinners included:
rotatingPlane
wave
wanderingCubes
spinner
chasingDots
threeBounce
circle
cubeGrid
fadingCircle
foldingCube
How to use it:
1. Put the main style sheet jquery.loadingModal.css in the header of the html page.

1
<link rel="stylesheet" href="css/jquery.loadingModal.css">
2. Put the jQuery library and the JavaScript file jquery.loadingModal.js at the end of the document.

1
<script src="//code.jquery.com/jquery-3.1.1.slim.min.js"></script>
2
<script src="js/jquery.loadingModal.js"></script>
3. Call the function on the target container where you want to display a fullscreen modal with default loading spinner and custom text message.

1
$('body').loadingModal({
2
  text: 'Loading...'
3
});
4. Here are full options with default values to config the fullscreen loading modal.

1
$('body').loadingModal({
2
  position: 'auto',
3
  text: '',
4
  color: '#fff',
5
  opacity: '0.7',
6
  backgroundColor: 'rgb(0,0,0)',
7
  animation: 'doubleBounce'
8
});
5. Public methods.

1
// hide the loading modal
2
$('body').loadingModal('hide');
3
 
4
// destroy the plugin
5
$('body').loadingModal('destroy');
