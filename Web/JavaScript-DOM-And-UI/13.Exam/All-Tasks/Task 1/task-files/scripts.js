function createImagesPreviewer(selector, items) {
    var container = document.querySelector(selector);
    //container.style.width = '1000px';
    //container.style.height = '100%';
    //container.style.margin = '0 auto';
    //container.style.border = '1px solid black';

    var imageInTheMiddle = null;

    var currentTitle = document.createElement('strong');
    currentTitle.style.display = 'block';
    currentTitle.style.textAlign = 'center';
    currentTitle.style.marginBottom = '10px';

    var currentImage = document.createElement('img');
    currentImage.style.width = '150px';
    currentImage.style.marginLeft = '5px';
    currentImage.style.marginRight = '5px';
    currentImage.style.borderRadius = '10px';

    var galleryList = document.createElement('div');
    galleryList.className = 'gallery-list';
    galleryList.style.position = 'absolute';
    galleryList.style.top = '20px';
    galleryList.style.right = '50px';
    galleryList.style.padding = '10px';
    galleryList.style.width = '200px';
    galleryList.style.height = '520px';
    //galleryList.style.border = '1px solid #000';
    galleryList.style.overflowY = 'scroll';

    var filterDiv = document.createElement('div');
    filterDiv.style.textAlign = 'center';

    var filterLabel = document.createElement('label');
    filterLabel.innerHTML = 'Filter';
    filterLabel.style.display = 'block';

    var filterInput = document.createElement('input');
    filterInput.style.width = '165px';

    filterDiv.appendChild(filterLabel);
    filterDiv.appendChild(filterInput);
    galleryList.appendChild(filterDiv);

    for (var i = 0; i < items.length; i++) {
        var imageContainer = document.createElement('div');
        imageContainer.className = 'image-container';
        imageContainer.style.margin = '10px';
        imageContainer.style.padding = '5px';
        imageContainer.style.width = '160px';
        //imageContainer.style.border = '1px solid #000';

        currentTitle.innerHTML = items[i].title;
        imageContainer.appendChild(currentTitle.cloneNode(true));

        currentImage.src = items[i].url;
        imageContainer.appendChild(currentImage.cloneNode(true));
        imageContainer.addEventListener('mouseover', onMouseover);
        imageContainer.addEventListener('mouseout', onMouseout);
        imageContainer.addEventListener('click', onMouseClick)

        galleryList.appendChild(imageContainer);
    }

    function onMouseover() {
        this.style.backgroundColor = '#ccc';
    }

    function onMouseout() {
        this.style.backgroundColor = '';
    }

    function onMouseClick() {
        imageInTheMiddle = showImageInTheMiddle(); // !!! 
    }

    if (imageInTheMiddle === null) {
        imageInTheMiddle = showImageInTheMiddle(items[0]);
    }

    function showImageInTheMiddle(target) {
        var CURRENT_WIDTH = 400;
        var imgTitle = document.createElement('strong');
        var imgURL = document.createElement('img');
        var imgDiv = document.createElement('div');

        imgTitle.innerHTML = target.title;
        imgTitle.style.display = 'block';
        imgTitle.style.fontSize = '30px';
        imgTitle.style.marginBottom = '20px';

        imgURL.src = target.url;
        imgURL.style.borderRadius = '20px';
        imgURL.style.width = CURRENT_WIDTH + 'px';

        imgDiv.style.width = CURRENT_WIDTH + 'px';
        imgDiv.style.textAlign = 'center';
        imgDiv.style.position = 'absolute';
        imgDiv.style.top = '100px';
        imgDiv.style.left = (window.innerWidth / 2 - CURRENT_WIDTH / 2) + 'px';

        imgDiv.appendChild(imgTitle);
        imgDiv.appendChild(imgURL);
        return imgDiv;
    }

    container.appendChild(imageInTheMiddle);
    container.appendChild(galleryList);
}