10 Nginx Rules to Harden WordPress Security

https://www.hongkiat.com/blog/nginx-rules-for-wordpress-security/

# Limit XMLRPC Access

XMLRPC endpoint in WordPress is used to allow an external application to interact with WordPress data. For example, it can allow adding, creating, or deleting a post. However, XMLRPC is also a **common attack vector** where the attacker may be able to perform those operations without authorization. It’s better to **allow request to XMLRPC from authorized IP** that you trust, like so:

```
location ~* /xmlrpc.php$ {
 allow 172.0.1.1;
 deny all;
}
```

Once the above is added, you should see the **403 error code response** when loading xmlrpc.php in the browser.

# Limit Request Types

Most of the time your website may only perform two types fo requests i.e. **GET to retrieve data from your site and POST to upload data** to your site. Limiting the type of request that our site can handle to only these two sounds like a good idea here.

```
if (`$request_method !~ ^(GET|POST)$ ) {
 return 444;
}
```

# Direct PHP File Access

If somehow, a hacker successfully sneaks in a PHP file onto your site, they’ll be able to run this file by loading file which effectively becomes a backdoor to infiltrate your site. We should **disable direct access to any PHP files** by adding the following rules:

```
location ~* /(?:uploads|files|wp-content|wp-includes|akismet)/.*.php$ {
 deny all;
 access_log off;
 log_not_found off;
}
```

# Dotfiles

Similar to PHP file, a dotfile like .htaccess, .user.ini, and .git may contain sensitive information. To be on the safer side, it’s better to **disable direct access to these files**.

```
location ~ /\.(svn|git)/* {
 deny all;
 access_log off;
 log_not_found off;
}

location ~ /\.ht {
 deny all;
 access_log off;
 log_not_found off;
}

location ~ /\.user.ini {
 deny all;
 access_log off;
 log_not_found off;
}
```

# Hide Nginx and PHP version

Certain information should better not to be exposed like the Nginx version as well as the PHP version. This won’t prevent the attack itself. However, assuming particular Ningx or PHP version turns out has vulnerability exposed, the attacker won’t get to know easily from your site. To hide the Nginx version:

```
#Hide the nginx version.
server_tokens off;

#Hide the PHP version.
fastcgi_hide_header X-Powered-By;
proxy_hide_header X-Powered-By;
```

# Security Headers

Security headers provide an extra layer of security by dictating the browser behavior. The X-Frame-Options, for example, will prevent your site to load from an iframe, unless it’s from your own site. The Strict-Transport-Security will **enforce browser to load your site from HTTPS**.

```
add_header X-Frame-Options SAMEORIGIN;
add_header Strict-Transport-Security "max-age=31536000"`;
add_header X-Content-Type-Options nosniff;
add_header X-XSS-Protection "1; mode=block"`;
```

# Block Subdirectory Access

If your site runs on a sub-directory like /blog, it’s better to **allow access to this sub-directory**. It means that any obscure access to other directories which an attacker always looks for, for example, /82jdkj/?.php are blocked.

```
location ~ ^/(?!(blog)/?) {
 deny all;
 access_log off;
 log_not_found off;
}
```

# Reduce Spam

Spam comment, although it may not break your site, it’ll flood your database with garbage content or a malicious content that could possibly leverage as a vector. To **reduce spam entries**, you can add the following rules to your Nginx config alongside with a Spam protection plugin like [Akismet](https://akismet.com/).

```
set $comment_flagged 0;
set $comment_request_method 0;
set $comment_request_uri 0;
set $comment_referrer 1;

if (`$request_method ~ "POST"`){
 set $comment_request_method 1;
}

if (`$request_uri ~ "/wp-comments-post\.php$"`){
 set $comment_request_method 1;
}

if (`$http_referer !~ "^https?://(([^/]+\.)?site\.com|jetpack\.wordpress\.com/jetpack-comment)(/|$)"`){
 set $comment_referrer 0;
}

set $comment_flagged "${comment_request_method}${comment_request_uri}${comment_referrer}"`;
if (`$comment_flagged = "111"`) {
 return 403;
}
```

# Limit Requests

The WordPress login page, wp-login.php, is a common endpoint for a brute-force attack. The **attacker will try to break through your site** by submitting multiple username and password combination and this usually done multiple times in a second.

For this, we can apply a rule that will limit the number of requests that the page can handle per second. Here we **set the limit to 2 requests per second**, otherwise, the request will be blocked.

```
limit_req_zone $binary_remote_addr zone=WPRATELIMIT:10m rate=2r/s;

location ~ \wp-login.php$ {
  limit_req zone=WPRATELIMIT;
}
```

# Disable Directory Listing

Last but not least, you should disable the directory listing so the attacker won’t get to know what’s in the directory. There’s very little reason that I know where directory listing is useful on a WordPress site.

```
autoindex off;
```