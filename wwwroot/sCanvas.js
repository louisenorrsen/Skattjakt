window.canvasInterop = {
    setupCanvas:
        function (w,h) {
            var canvas = document.getElementById("myCanvas");
            var ctx = canvas.getContext("2d");
            var width = canvas.width;
            canvas.height = canvas.width;
            var height = canvas.height;

            // Set the fill color for the background
            ctx.fillStyle = "#FFFFFF"; // Light blue color; change this to any color you like
            // Fill the entire canvas with the selected color
            ctx.fillRect(0, 0, width, height);

            ctx.moveTo(width / 2, height / 2);
            ctx.lineTo(width / 2 + w, height / 2 + h);
            ctx.stroke();

            ctx.beginPath();
            ctx.arc(width / 2, height / 2, height/2, 0, 2 * Math.PI);
            ctx.stroke();

            ctx.beginPath();
            ctx.arc(width / 2, height / 2, 20, 0, 2 * Math.PI);
            ctx.stroke();

            ctx.beginPath();
            ctx.arc(width / 2 + w, height / 2 + h, 20, 0, 2 * Math.PI);
            ctx.stroke();
        }
};