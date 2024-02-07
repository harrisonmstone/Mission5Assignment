// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('#calculate').click(function (event) {
        event.preventDefault();
        // Get the entered number of hours
        var hours = parseFloat($('#hours').val());

        // Validate if the input is a positive number
        if (isNaN(hours) || hours < 0) {
            $('#output').text("Please enter a valid positive number of hours.");
        } else {
            // Calculate the total cost
            var hourlyRate = 25
            var totalCost = hours * hourlyRate;
            $('#output').text("Total Cost: $" + totalCost.toFixed(2));
        }
    });
});
