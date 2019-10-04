

$(document).ready(function () {

// <!-- <=================================================> -->
  // <!-- <=================START NAV BAR===================> -->
  // <!-- <=================================================> -->




  $(window).scroll(function () {
    if (scrollY > 30) {
      $("#header_navs").css("display", "none")
      $("#logo_img").css("display","none")
      // $("#logo_img2").css("display","block")

    } else {
      $("#header_navs").css("display", "")
    }
    if (scrollY > 630) {
      $("#logo_img").css("display","none")
      $("#logo_img2").css("display","block")
      $("#header_navs").css("display", "block");
      $("#header_navs  ").css("color", "red");
      $("#header_navs #src_head ").css("background-color", "white");
      $("#header_navs  ").css("background-color", "rgba(136,136,136,0.6)");
      $("#header_navs  ").css("box-shadow", "0px 23px 34px -12px black");
     


    } else {
      $("#logo_img").css("display","block")
      $("#logo_img2").css("display","none")
      $("#header_navs  ").css("color", "red")
      $("#header_navs  ").css("background-color", "");
      $("#header_navs #src_head ").css("background-color", "#C4C2BE");
      $("#header_navs  ").css("height", "");
      $("#header_navs  ").css("box-shadow", "none");
    
    }
  })
  // <!-- <=================================================> -->
  // <!-- <==================END NAV BAR====================> -->
  // <!-- <=================================================> -->




  var offset = 600;
  var duration = 500;
  $(window).scroll(function () {
    if ($(this).scrollTop() > offset) {
      $('.back-to-top').fadeIn(400);
    } else {
      $('.back-to-top').fadeOut(400);
    }
  });

  $('.back-to-top').on('click', function (event) {
    event.preventDefault();
    $('html, body').animate({
      scrollTop: 0
    }, 1500);
    return false;
  });










  var swiper = new Swiper('.swiper-container', {
    pagination: {
      el: '.swiper-pagination',
      type: 'fraction',
    },
    navigation: {
      nextEl: '.swiper-button-next',
      prevEl: '.swiper-button-prev',
    },
  });




  $(".navbar-toggler-icon").click(function () {
    $(".header-text").toggleClass('d-none');


  })


  if ($(".owl-carousel").length > 0) {
    $('.owl-carousel').owlCarousel({
      loop: true,
      margin: 10,
      responsiveClass: true,
      responsive: {
        0: {
          items: 1,
          nav: false
        },
        600: {
          items: 1,
          nav: false
        },
        1000: {
          items: 1,
          nav: false,
          loop: true
        }
      }
    })
  }

  $(document).on('click', '.number-spinner button', function () {
    var btn = $(this),
      oldValue = btn.closest('.number-spinner').find('input').val().trim(),
      newVal = 0;

    if (btn.attr('data-dir') == 'up') {
      newVal = parseInt(oldValue) + 1;
    } else {
      if (oldValue > 1) {
        newVal = parseInt(oldValue) - 1;
      } else {
        newVal = 1;
      }
    }
    btn.closest('.number-spinner').find('input').val(newVal);
  });

  $(window).scroll(function () {
    if ($(this).scrollTop() > 300) {

      $('#myBtn').fadeIn();
    } else {
      $('#myBtn').fadeOut();
    }

  });
  $('#myBtn').click(function () {
    $('body,html').animate({
      scrollTop: 0
    }, 1000);
    return false;
  });


});

