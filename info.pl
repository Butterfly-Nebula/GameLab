#!/usr/bin/perl

use CGI;

my $cgi = CGI->new;

print $cgi->header( -type => 'text/plain' );

print $ENV{SERVER_SOFTWARE};
