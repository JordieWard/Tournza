console.log("SCRIPT LOADED");
const navButtons = document.querySelectorAll("[data-page]");
const pages = document.querySelectorAll(".page");
const navLinks = document.querySelectorAll(".nav-link");

function showPage(pageId) {
  pages.forEach((page) => {
    page.classList.remove("active");
  });

  const activePage = document.getElementById(pageId);
  if (activePage) {
    activePage.classList.add("active");
  }

  navLinks.forEach((link) => {
    link.classList.remove("active");
    if (link.dataset.page === pageId) {
      link.classList.add("active");
    }
  });

  window.scrollTo({ top: 0, behavior: "smooth" });
}

navButtons.forEach((button) => {
  button.addEventListener("click", () => {
    const pageId = button.dataset.page;
    if (pageId) {
      showPage(pageId);
    }
  });
});
