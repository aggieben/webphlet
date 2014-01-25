﻿// Generated by CoffeeScript 1.6.3
(function($) {
  var last, save;
  save = function() {
    var content, pid;
    content = {
      __RequestVerificationToken: $('article.content input[name="__RequestVerificationToken"]').val(),
      title: $('article.content .title :not(.Medium-placeholder)').html(),
      subtitle: $('article.content .subtitle :not(.Medium-placeholder)').html(),
      body: $('article.content section.editable:not(.Medium-placeholder)').html()
    };
    if ((pid = $('article.content').data('post-id'))) {
      content.postId = pid;
    }
    return $.ajax('/post/draft', {
      type: 'POST',
      data: content,
      error: function(jqxhr, status, error) {
        console.log(error);
        console.log(status);
        return console.log(jqxhr);
      },
      success: function(data, status, jqxhr) {
        return window.location.pathname = "/post/edit/" + data;
      }
    });
  };
  last = -1;
  return $('article.content section.editable').on('input', function(e) {
    console.log('saving draft...');
    clearTimeout(last);
    return last = setTimeout((function() {
      return save();
    }), 500);
  });
})(jQuery);