{\rtf1\ansi\ansicpg1252\cocoartf1187\cocoasubrtf340
{\fonttbl\f0\fnil\fcharset0 Consolas;}
{\colortbl;\red255\green255\blue255;\red255\green255\blue255;}
\margl1440\margr1440\vieww10800\viewh8400\viewkind0
\deftab720
\pard\pardeftab720\sl420

\f0\fs28 \cf0 \cb2 using System;\
\
class HelloWorld\
\{\
    static void Main()\
    \{\
#if DebugConfig\
        Console.WriteLine("WE ARE IN THE DEBUG CONFIGURATION");\
#endif\
\
        Console.WriteLine("Hello, world!");\
    \}\
\}\
}