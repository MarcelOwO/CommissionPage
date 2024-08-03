

// wwwroot/js/site.js
window.showLoadingSpinner = () => {
    document.querySelector('.loading-spinner').style.display = 'block';
};

window.hideLoadingSpinner = () => {
    document.querySelector('.loading-spinner').style.display = 'none';
};
