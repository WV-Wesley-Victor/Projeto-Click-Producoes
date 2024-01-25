window.addEventListener("load", function () {
    var photoList = document.getElementById("photoList");
    var images = photoList.getElementsByTagName("img");

    for (var i = 0; i < images.length; i++) {
        var image = images[i];
        var aspectRatio = image.width / image.height;

        if (aspectRatio < 1) {
            image.parentNode.classList.add("vertical");
        } else {
            image.parentNode.classList.add("horizontal");
        }
    }
});