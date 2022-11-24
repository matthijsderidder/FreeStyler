# FreeStyler Client
![FreeStyler Logo](freestyler_logo.png)

## TCP/IP
### Byte Protocol: 9 bytes
| 0 | 1 | 2 | 3 | 4 - 5 | 6 | 7 - 8 |
| - | - | - | - | ----- | - | ----- |
| F | S | O | D |  XXX  | Y |  ZZZ  |

```
Byte 0: "F"  
Byte 1: "S"  
Byte 2: "O"  
Byte 3: "D"  
Byte 4 and 5: Code ("XXX")  
Byte 6: TCP/IP Argument  
		- Button State: 0 Release, 255 Click  
		- Fader Value: 0 to 255
Byte 7 and 8: (For later use)
```

### ASCII Protocol: 13 chars
| 0 | 1 | 2 | 3 | 4 - 6 |  7 - 9  | 10 - 12 |
| - | - | - | - | ----- | ------- | ------- |
| F | S | O | C |  XXX  | 0 - 255 |   ZZZ   |

```
Char 0: "F"  
Char 1: "S"  
Char 2: "O"  
Char 3: "C"  
Char 4 to 6: Code ("XXX")
Char 7 to 9: TCP/IP Argument
		- Button State: 0 Release, 255 Click  
		- Fader Value: 0 to 255
Char 10 to 12: Argument ("ZZZ")
```

## Request button captions and other data
### Byte Protocol: 9 bytes
| 0 | 1 | 2 | 3 | 4 - 6 | 7 - 8 |
| - | - | - | - | ----- | ----- |
| F | S | B | C |  XXX  |  000  |

```
Byte 0: "F"  
Byte 1: "S"  
Byte 2: "B"  
Byte 3: "C"  
Byte 4, 5 and 6: Code ("XXX")  
Byte 7, 8 en 9: 0  
```

| Code | Description							|
| ---- | -------------------------------------- |
| 001  | Cue captions							|
| 002  | Override button captions				|
| 003  | Cuelist captions of current page		|
| 004  | All cuelist captions					|
| 005  | Cue status								| 
| 006  | Override buttons flash/latch setting	|
| 007  | Override buttons status				|
| 008  | Group names							|
| 008  | Group status							|
| 010  | FreeStyler version						|
| 011  | Submaster names						|
| 012  | Submaster status						|
| 013  | Submaster intensity					|
| 014  | Blackout,Freeze,favorite status		|
| 015  | Current selected cue in submasters		|
| 016  | Cuelist status							|
| 017  | Fixture names							|
| 018  | Fixture address						|
| 019  | Cue speed								|
| 020  | Master cue speed						|
| 021  | Master intensity						|
| 022  | Fog and Fan levels						|
| 023  | Fixture status selected/unselected		|

**Examples:**
- "FSBC001000" -> You will receive the 20 captions of the current cue (comma separated)  
- "FSBC002000" -> You will receive the 32 captions of the current override buttons (comma separated)  
- "FSBC003000" -> You will receive the 16 captions of the current cuelist's page (comma separated)  

## Commands
| Function							| Code	| SendMessage<br>Argument		| TCP/IP<br>Argument				| Type		|
| :-------------------------------- | ----:	| :---------------------------- | :-------------------------------- | --------- |
| Toggle all fixtures				|     0	| 1								| 255								| Fixed		|
| Toggle favorite					|     1	| 1								| 255								| Fixed		|
| Toggle blackout					|     2	| 1								| 255								| Fixed		|
| Toggle Freeze						|   123	| 1								| 255								| Fixed		|
| Release all						|    24	| 1								| 255								| Fixed		|
| Fog / Smoke						|   176	| 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Fog level							|   304	| 0-255							| 0-255								| Range		|
| Fog fan level						|   305	| 0-255							| 0-255								| Range		|
| Lock MIDI input					|   181	| 1								| 255								| Fixed		|
| Open all							|   569 | 1								| 255								| Fixed		|
| Open gobo							|     3 | 1								| 255								| Fixed		|
| Open color						|     4 | 1								| 255								| Fixed		|
| Open Pan/Tilt						|	  5 | 1								| 255								| Fixed		|
| Open beam							|     6 | 1								| 255								| Fixed		|
| Open macro						|     7 | 1								| 255								| Fixed		|
| Open dmx400						|     8 | 1								| 255								| Fixed		|
| Open Lamp							|    10 | 1								| 255								| Fixed		|
| Open create sequence				|    11 | 1								| 255								| Fixed		|
| Open cue							|    12 | 1								| 255								| Fixed		|
| Open sound						|    13 | 1								| 255								| Fixed		|
| Open output						|    14 | 1								| 255								| Fixed		|
| Open framing						|    29 | 1								| 255								| Fixed		|
| Open override buttons				|   570 | 1								| 255								| Fixed		|
| Open commandline					|   571 | 1								| 255								| Fixed		|
| Open master						|   572 | 1								| 255								| Fixed		|
| Open submaster					|   573 | 1								| 255								| Fixed		|
| Open Smoke						|   574 | 1								| 255								| Fixed		|
| Show sliders						|    15 | 1								| 255								| Fixed		|
| Next gobo							|    16 | 1								| 255								| Fixed		|
| Next color						|    17 | 1								| 255								| Fixed		|
| Next gobo2						|    18 | 1								| 255								| Fixed		|
| Next color2						|    19 | 1								| 255								| Fixed		|
| Previous Gobo						|   177 | 1								| 255								| Fixed		|
| Previous Color					|   178 | 1								| 255								| Fixed		|
| Previous Gobo2					|   179 | 1								| 255								| Fixed		|
| Previous Color2					|   180 | 1								| 255								| Fixed		|
| Pan right							|    20 | 1								| 255								| Fixed		|
| Pan 16 right						|   585 | 1								| 255								| Fixed		|
| Pan left							|    21 | 1								| 255								| Fixed		|
| Pan 16 left						|   586 | 1								| 255								| Fixed		|
| Center							|   566 | 1								| 255								| Fixed		|
| Tilt up							|    22 | 1								| 255								| Fixed		|
| Tilt 16 up						|   587 | 1								| 255								| Fixed		|
| Tilt down							|    23 | 1								| 255								| Fixed		|
| Tilt 16 down						|   588 | 1								| 255								| Fixed		|
| Pan lock							|   567 | 1								| 255								| Fixed		|
| Tilt lock							|   568 | 1								| 255								| Fixed		|
| Flip								|   565 | 1								| 255								| Fixed		|
| Enable joystick					|    44 | 1								| 255								| Fixed		|
| Toggle Joystick Pan/Tilt			|   122 | 1								| 255								| Fixed		|
| Toggle Relative Pan-Tilt			|   150 | 1								| 255								| Fixed		|
| New sequence						|    25 | 1								| 255								| Fixed		|
| Insert scene						|    26 | 1								| 255								| Fixed		|
| Remove scene						|    27 | 1								| 255								| Fixed		|
| Add scene							|    28 | 1								| 255								| Fixed		|
| Next scene						|   575 | 1								| 255								| Fixed		|
| Previous scene					|   576 | 1								| 255								| Fixed		|
| Play sequence						|   577 | 1								| 255								| Fixed		|
| Fade time +1						|   589 | 1								| 255								| Fixed		|
| Fade time -1						|   590 | 1								| 255								| Fixed		|
| Speed time +1						|   591 | 1								| 255								| Fixed		|
| Speed time -1						|   592 | 1								| 255								| Fixed		|
| Open sequence						|   593 | 1								| 255								| Fixed		|
| Save sequence						|   594 | 1								| 255								| Fixed		|
| Quicksave							|   578 | 1								| 255								| Fixed		|
| Save to all						|   579 | 1								| 255								| Fixed		|
| Undo								|   580 | 1								| 255								| Fixed		|
| Open FX							|   581 | 1								| 255								| Fixed		|
| Zone 1							|    30 | 1								| 255								| Fixed		|
| Zone 2							|    31 | 1								| 255								| Fixed		|
| Zone 3							|    32 | 1								| 255								| Fixed		|
| Zone 4							|    33 | 1								| 255								| Fixed		|
| Select next fixture				|   288 | 1								| 255								| Fixed		|
| Select previous fixture			|   289 | 1								| 255								| Fixed		|
| Select even fixtures				|   290 | 1								| 255								| Fixed		|
| Select odd fixtures				|   291 | 1								| 255								| Fixed		|
| Select same even fixtures			|   292 | 1								| 255								| Fixed		|
| Select same odd fixtures			|   293 | 1								| 255								| Fixed		|
| Locate selected fixtures			|   294 | 1								| 255								| Fixed		|
| Enable sound selected fixtures	|   295 | 1								| 255								| Fixed		|
| Previous group					|   296 | 1								| 255								| Fixed		|
| Next Group						|   297 | 1								| 255								| Fixed		|
| Group 1							|    34 | 1								| 255								| Fixed		|
| Group 2							|    35 | 1								| 255								| Fixed		|
| Group 3							|    36 | 1								| 255								| Fixed		|
| Group 4							|    37 | 1								| 255								| Fixed		|
| Group 5							|    38 | 1								| 255								| Fixed		|
| Group 6							|    39 | 1								| 255								| Fixed		|
| Group 7							|    30 | 1								| 255								| Fixed		|
| Group 8							|    40 | 1								| 255								| Fixed		|
| Group 9							|    41 | 1								| 255								| Fixed		|
| Group 10							|    42 | 1								| 255								| Fixed		|
| Group 11							|   550 | 1								| 255								| Fixed		|
| Group 12							|   551 | 1								| 255								| Fixed		|
| Group 13							|   552 | 1								| 255								| Fixed		|
| Group 14							|   553 | 1								| 255								| Fixed		|
| Group 15							|   554 | 1								| 255								| Fixed		|
| Group 16							|   555 | 1								| 255								| Fixed		|
| Group 17							|   556 | 1								| 255								| Fixed		|
| Group 18							|   557 | 1								| 255								| Fixed		|
| Group 19							|   558 | 1								| 255								| Fixed		|
| Group 20							|   559 | 1								| 255								| Fixed		|
| Group 21							|   560 | 1								| 255								| Fixed		|
| Group 22							|   561 | 1								| 255								| Fixed		|
| Group 23							|   562 | 1								| 255								| Fixed		|
| Group 24							|   563 | 1								| 255								| Fixed		|
| Blackout group 1					|    98 | 1								| 255								| Fixed		|
| Blackout group 2					|    99 | 1								| 255								| Fixed		|
| Blackout group 3					|   100 | 1								| 255								| Fixed		|
| Blackout group 4					|   101 | 1								| 255								| Fixed		|
| Blackout group 5					|   102 | 1								| 255								| Fixed		|
| Blackout group 6					|   103 | 1								| 255								| Fixed		|
| Blackout group 7					|   104 | 1								| 255								| Fixed		|
| Blackout group 8					|   105 | 1								| 255								| Fixed		|
| Blackout group 9					|   106 | 1								| 255								| Fixed		|
| Blackout group 10					|   107 | 1								| 255								| Fixed		|
| Blackout group 11					|   108 | 1								| 255								| Fixed		|
| Blackout group 12					|   109 | 1								| 255								| Fixed		|
| Blackout group 13					|   110 | 1								| 255								| Fixed		|
| Blackout group 14					|   111 | 1								| 255								| Fixed		|
| Blackout group 15					|   112 | 1								| 255								| Fixed		|
| Blackout group 16					|   113 | 1								| 255								| Fixed		|
| Blackout group 17					|   114 | 1								| 255								| Fixed		|
| Blackout group 18					|   115 | 1								| 255								| Fixed		|
| Blackout group 19					|   116 | 1								| 255								| Fixed		|
| Blackout group 20					|   117 | 1								| 255								| Fixed		|
| Blackout group 21					|   118 | 1								| 255								| Fixed		|
| Blackout group 22					|   119 | 1								| 255								| Fixed		|
| Blackout group 23					|   120 | 1								| 255								| Fixed		|
| Blackout group 24					|   121 | 1								| 255								| Fixed		|
| Dis. override group 1				|   240 | 1								| 255								| Fixed		|
| Dis. override group 2				|   241 | 1								| 255								| Fixed		|
| Dis. override group 3				|   242 | 1								| 255								| Fixed		|
| Dis. override group 4				|   243 | 1								| 255								| Fixed		|
| Dis. override group 5				|   244 | 1								| 255								| Fixed		|
| Dis. override group 6				|   245 | 1								| 255								| Fixed		|
| Dis. override group 7				|   246 | 1								| 255								| Fixed		|
| Dis. override group 8				|   247 | 1								| 255								| Fixed		|
| Dis. override group 9				|   248 | 1								| 255								| Fixed		|
| Dis. override group 10			|   249 | 1								| 255								| Fixed		|
| Dis. override group 11			|   250 | 1								| 255								| Fixed		|
| Dis. override group 12			|   251 | 1								| 255								| Fixed		|
| Dis. override group 13			|   252 | 1								| 255								| Fixed		|
| Dis. override group 14			|   253 | 1								| 255								| Fixed		|
| Dis. override group 15			|   254 | 1								| 255								| Fixed		|
| Dis. override group 16			|   255 | 1								| 255								| Fixed		|
| Dis. override group 17			|   256 | 1								| 255								| Fixed		|
| Dis. override group 18			|   257 | 1								| 255								| Fixed		|
| Dis. override group 19			|   258 | 1								| 255								| Fixed		|
| Dis. override group 20			|   259 | 1								| 255								| Fixed		|
| Dis. override group 21			|   260 | 1								| 255								| Fixed		|
| Dis. override group 22			|   261 | 1								| 255								| Fixed		|
| Dis. override group 23			|   262 | 1								| 255								| Fixed		|
| Dis. override group 24			|   263 | 1								| 255								| Fixed		|
| Multiselect sequence				|    45 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Toggle Sequence 1					|    46 | 1								| 255								| Fixed		|
| Toggle Sequence 2					|    47 | 1								| 255								| Fixed		|
| Toggle Sequence 3					|    48 | 1								| 255								| Fixed		|
| Toggle Sequence 4					|    49 | 1								| 255								| Fixed		|
| Toggle Sequence 5					|    50 | 1								| 255								| Fixed		|
| Toggle Sequence 6					|    51 | 1								| 255								| Fixed		|
| Toggle Sequence 7					|    52 | 1								| 255								| Fixed		|
| Toggle Sequence 8					|    53 | 1								| 255								| Fixed		|
| Toggle Sequence 9					|    54 | 1								| 255								| Fixed		|
| Toggle Sequence 10				|    55 | 1								| 255								| Fixed		|
| Toggle Sequence 11				|    56 | 1								| 255								| Fixed		|
| Toggle Sequence 12				|    57 | 1								| 255								| Fixed		|
| Toggle Sequence 13				|    58 | 1								| 255								| Fixed		|
| Toggle Sequence 14				|    59 | 1								| 255								| Fixed		|
| Toggle Sequence 15				|    60 | 1								| 255								| Fixed		|
| Toggle Sequence 16				|    61 | 1								| 255								| Fixed		|
| Toggle Sequence 17				|    62 | 1								| 255								| Fixed		|
| Toggle Sequence 18				|    63 | 1								| 255								| Fixed		|
| Toggle Sequence 19				|    64 | 1								| 255								| Fixed		|
| Toggle Sequence 20				|    65 | 1								| 255								| Fixed		|
| Start sequence 1					|   505 | 1								| 255								| Fixed		|
| Start sequence 2					|   506 | 1								| 255								| Fixed		|
| Start sequence 3					|   507 | 1								| 255								| Fixed		|
| Start sequence 4					|   508 | 1								| 255								| Fixed		|
| Start sequence 5					|   509 | 1								| 255								| Fixed		|
| Start sequence 6					|   510 | 1								| 255								| Fixed		|
| Start sequence 7					|   511 | 1								| 255								| Fixed		|
| Start sequence 8					|   512 | 1								| 255								| Fixed		|
| Start sequence 9					|   513 | 1								| 255								| Fixed		|
| Start sequence 10					|   514 | 1								| 255								| Fixed		|
| Start sequence 11					|   515 | 1								| 255								| Fixed		|
| Start sequence 12					|   516 | 1								| 255								| Fixed		|
| Start sequence 13					|   517 | 1								| 255								| Fixed		|
| Start sequence 14					|   518 | 1								| 255								| Fixed		|
| Start sequence 15					|   519 | 1								| 255								| Fixed		|
| Start sequence 16					|   520 | 1								| 255								| Fixed		|
| Start sequence 17					|   521 | 1								| 255								| Fixed		|
| Start sequence 18					|   522 | 1								| 255								| Fixed		|
| Start sequence 19					|   523 | 1								| 255								| Fixed		|
| Start sequence 20					|   524 | 1								| 255								| Fixed		|
| Stop sequence 1					|   525 | 1								| 255								| Fixed		|
| Stop sequence 2					|   526 | 1								| 255								| Fixed		|
| Stop sequence 3					|   527 | 1								| 255								| Fixed		|
| Stop sequence 4					|   528 | 1								| 255								| Fixed		|
| Stop sequence 5					|   529 | 1								| 255								| Fixed		|
| Stop sequence 6					|   530 | 1								| 255								| Fixed		|
| Stop sequence 7					|   531 | 1								| 255								| Fixed		|
| Stop sequence 8					|   532 | 1								| 255								| Fixed		|
| Stop sequence 9					|   533 | 1								| 255								| Fixed		|
| Stop sequence 10					|   534 | 1								| 255								| Fixed		|
| Stop sequence 11					|   535 | 1								| 255								| Fixed		|
| Stop sequence 12					|   536 | 1								| 255								| Fixed		|
| Stop sequence 13					|   537 | 1								| 255								| Fixed		|
| Stop sequence 14					|   538 | 1								| 255								| Fixed		|
| Stop sequence 15					|   539 | 1								| 255								| Fixed		|
| Stop sequence 16					|   540 | 1								| 255								| Fixed		|
| Stop sequence 17					|   541 | 1								| 255								| Fixed		|
| Stop sequence 18					|   542 | 1								| 255								| Fixed		|
| Stop sequence 19					|   543 | 1								| 255								| Fixed		|
| Stop sequence 20					|   544 | 1								| 255								| Fixed		|
| Masterspeed						|   206	| 0-255							| 0-255								| Range		|
| Sequence 1 speed					|   156	| 0-255							| 0-255								| Range		|
| Sequence 2 speed					|   157	| 0-255							| 0-255								| Range		|
| Sequence 3 speed					|   158	| 0-255							| 0-255								| Range		|
| Sequence 4 speed					|   159	| 0-255							| 0-255								| Range		|
| Sequence 5 speed					|   160	| 0-255							| 0-255								| Range		|
| Sequence 6 speed					|   161	| 0-255							| 0-255								| Range		|
| Sequence 7 speed					|   162	| 0-255							| 0-255								| Range		|
| Sequence 8 speed					|   163	| 0-255							| 0-255								| Range		|
| Sequence 9 speed					|   164	| 0-255							| 0-255								| Range		|
| Sequence 10 speed					|   165	| 0-255							| 0-255								| Range		|
| Sequence 11 speed					|   166	| 0-255							| 0-255								| Range		|
| Sequence 12 speed					|   167	| 0-255							| 0-255								| Range		|
| Sequence 13 speed					|   168	| 0-255							| 0-255								| Range		|
| Sequence 14 speed					|   169	| 0-255							| 0-255								| Range		|
| Sequence 15 speed					|   170	| 0-255							| 0-255								| Range		|
| Sequence 16 speed					|   171	| 0-255							| 0-255								| Range		|
| Sequence 17 speed					|   172	| 0-255							| 0-255								| Range		|
| Sequence 18 speed					|   173	| 0-255							| 0-255								| Range		|
| Sequence 19 speed					|   174	| 0-255							| 0-255								| Range		|
| Sequence 20 speed					|   175	| 0-255							| 0-255								| Range		|
| Disable all buttons				|   265	| 1								| 255								| Fixed		|
| Previous Overr. tab				|   298 | 1								| 255								| Fixed		|
| Next overr. tab					|   299 | 1								| 255								| Fixed		|
| Overridebuttons tab 1				|   234 | 1								| 255								| Fixed		|
| Overridebuttons tab 2				|   235 | 1								| 255								| Fixed		|
| Overridebuttons tab 3				|   236 | 1								| 255								| Fixed		|
| Overridebuttons tab 4				|   237 | 1								| 255								| Fixed		|
| Overridebuttons tab 5				|   238 | 1								| 255								| Fixed		|
| Overridebuttons tab 6				|   239 | 1								| 255								| Fixed		|
| Override button 1					|    66 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 2					|    67 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 3					|    68 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 4					|    69 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 5					|    70 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 6					|    71 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 7					|    72 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 8					|    73 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 9					|    74 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 10				|    75 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 11				|    76 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 12				|    77 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 13				|    78 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 14				|    79 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 15				|    80 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 16				|    81 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 17				|    82 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 18				|    83 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 19				|    84 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 20				|    85 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 21				|    86 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 22				|    87 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 23				|    88 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 24				|    89 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 25				|    90 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 26				|    91 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 27				|    92 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 28				|    93 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 29				|    94 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 30				|    95 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 31				|    96 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Override button 32				|    97 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Overridebutton ...				|   348 | 1								| 255								| Fixed		|
| Gobo 1 channel					|   124 | 0-255							| 0-255								| Range		|
| Gobo 2 channel					|   125 | 0-255							| 0-255								| Range		|
| Gobo Rotation channel				|   126 | 0-255							| 0-255								| Range		|
| Gobo 2 Rotation channel			|   127 | 0-255							| 0-255								| Range		|
| Color channel						|   128 | 0-255							| 0-255								| Range		|
| Color 2 channel					|   129 | 0-255							| 0-255								| Range		|
| Cyan channel						|   130 | 0-255							| 0-255								| Range		|
| Magenta channel					|   131 | 0-255							| 0-255								| Range		|
| Yellow channel					|   132 | 0-255							| 0-255								| Range		|
| CTO/Amber channel					|   582 | 0-255							| 0-255								| Range		|
| White1 channel					|   583 | 0-255							| 0-255								| Range		|
| White2 channel					|   584 | 0-255							| 0-255								| Range		|
| Pan 8bit channel					|   133 | 0-255							| 0-255								| Range		|
| Tilt 8bit channel					|   135 | 0-255							| 0-255								| Range		|
| Shutter channel					|   137 | 0-255							| 0-255								| Range		|
| Intensity channel					|   138 | 0-255							| 0-255								| Range		|
| Prism channel						|   139 | 0-255							| 0-255								| Range		|
| Prism Rotation channel			|   140 | 0-255							| 0-255								| Range		|
| Focus channel						|   141 | 0-255							| 0-255								| Range		|
| Zoom channel						|   142 | 0-255							| 0-255								| Range		|
| Iris channel						|   143 | 0-255							| 0-255								| Range		|
| Frost channel						|   144 | 0-255							| 0-255								| Range		|
| Gobo ch. + 1						|   340 | 1								| 255								| Fixed		|
| Gobo ch. - 1						|   341 | 1								| 255								| Fixed		|
| Gobo2 ch. + 1						|   342 | 1								| 255								| Fixed		|
| Gobo2 ch. - 1						|   343 | 1								| 255								| Fixed		|
| Gobo3 ch. + 1						|   344 | 1								| 255								| Fixed		|
| Gobo3 ch. - 1						|   345 | 1								| 255								| Fixed		|
| Color ch. + 1						|   346 | 1								| 255								| Fixed		|
| Color ch. - 1						|   347 | 1								| 255								| Fixed		|
| Color2 ch. + 1					|   348 | 1								| 255								| Fixed		|
| Color2 ch. - 1					|   349 | 1								| 255								| Fixed		|
| GoboRot ch. + 1					|   350 | 1								| 255								| Fixed		|
| GoboRot ch. - 1					|   351 | 1								| 255								| Fixed		|
| GoboRot2 ch. + 1					|   352 | 1								| 255								| Fixed		|
| GoboRot2 ch. - 1					|   353 | 1								| 255								| Fixed		|
| Cyan ch. + 1						|   354 | 1								| 255								| Fixed		|
| Cyan ch. - 1						|   355 | 1								| 255								| Fixed		|
| Magenta ch. + 1					|   356 | 1								| 255								| Fixed		|
| Magenta ch. - 1					|   357 | 1								| 255								| Fixed		|
| Yellow ch. + 1					|   358 | 1								| 255								| Fixed		|
| Yellow ch. - 1					|   359 | 1								| 255								| Fixed		|
| Pan ch. + 1						|   360 | 1								| 255								| Fixed		|
| Pan ch. - 1						|   361 | 1								| 255								| Fixed		|
| Tilt ch. + 1						|   362 | 1								| 255								| Fixed		|
| Tilt ch. - 1						|   363 | 1								| 255								| Fixed		|
| Pan16 ch. + 1						|   364 | 1								| 255								| Fixed		|
| Pan16 ch. - 1						|   365 | 1								| 255								| Fixed		|
| Tilt16 ch. + 1					|   366 | 1								| 255								| Fixed		|
| Tilt16 ch. - 1					|   367 | 1								| 255								| Fixed		|
| Shutter ch. + 1					|   368 | 1								| 255								| Fixed		|
| Schutter ch. - 1					|   369 | 1								| 255								| Fixed		|
| Dimmer ch. + 1					|   370 | 1								| 255								| Fixed		|
| Dimmer ch. - 1					|   371 | 1								| 255								| Fixed		|
| Prism ch. + 1						|   372 | 1								| 255								| Fixed		|
| Prism ch. - 1						|   373 | 1								| 255								| Fixed		|
| PrismRot ch. + 1					|   374 | 1								| 255								| Fixed		|
| PrismRot ch. - 1					|   375 | 1								| 255								| Fixed		|
| Focus ch. + 1						|   376 | 1								| 255								| Fixed		|
| Focus ch. - 1						|   377 | 1								| 255								| Fixed		|
| Zoom ch. + 1						|   378 | 1								| 255								| Fixed		|
| Zoom ch. - 1						|   379 | 1								| 255								| Fixed		|
| Iris ch. + 1						|   380 | 1								| 255								| Fixed		|
| Iris ch. - 1						|   381 | 1								| 255								| Fixed		|
| Frost ch. + 1						|   382 | 1								| 255								| Fixed		|
| Frost ch. - 1						|   383 | 1								| 255								| Fixed		|
| Shutter open						|   545 | 1								| 255								| Fixed		|
| Shutter closed					|   546 | 1								| 255								| Fixed		|
| Strobe Low						|   547 | 1								| 255								| Fixed		|
| Strobe Med						|   548 | 1								| 255								| Fixed		|
| Strobe High						|   549 | 1								| 255								| Fixed		|
| Random Gobo 1						|   485 | 1								| 255								| Fixed		|
| Random Color 1					|   486 | 1								| 255								| Fixed		|
| Random Iris						|   487 | 1								| 255								| Fixed		|
| Random Strobe						|   488 | 1								| 255								| Fixed		|
| Random Dimmer						|   489 | 1								| 255								| Fixed		|
| Random RGB						|   490 | 1								| 255								| Fixed		|
| Random Pan/Tilt					|   491 | 1								| 255								| Fixed		|
| Random Gobo 1 by group			|   492 | 1								| 255								| Fixed		|
| Random Color 1 by group			|   493 | 1								| 255								| Fixed		|
| Random Iris by group				|   494 | 1								| 255								| Fixed		|
| Random Strobe by group			|   495 | 1								| 255								| Fixed		|
| Random Dimmer by group			|   496 | 1								| 255								| Fixed		|
| Random RGB by group				|	497 | 1								| 255								| Fixed		|
| Random Pan/Tilt by group			|   498 | 1								| 255								| Fixed		|
| Tap Sync							|     9 | 1								| 255								| Fixed		|
| Manual trigger					|   207 | 1								| 255								| Fixed		|
| Sound To Light trigger			|   232 | 1								| 255								| Fixed		|
| Disable tap / manual trigger		|   134 | 1								| 255								| Fixed		|
| Empty								|   136 | 1								| 255								| Fixed		|
| Midi Page 1						|   145 | 1								| 255								| Fixed		|
| Midi Page 2						|   146 | 1								| 255								| Fixed		|
| Midi Page 3						|   147 | 1								| 255								| Fixed		|
| Midi Page 4						|   148 | 1								| 255								| Fixed		|
| Midi Page 5						|   149 | 1								| 255								| Fixed		|
| Shift function					|   264 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| Touchscreen Page 1				|   499 | 1								| 255								| Fixed		|
| Touchscreen Page 2				|   500 | 1								| 255								| Fixed		|
| Touchscreen Page 3				|   501 | 1								| 255								| Fixed		|
| Touchscreen Page 4				|   502 | 1								| 255								| Fixed		|
| Touchscreen Page 5				|   503 | 1								| 255								| Fixed		|
| Touchscreen Page 6				|   504 | 1								| 255								| Fixed		|
| Master 100%						|   151 | 1								| 255								| Fixed		|
| Master 0%							|   152 | 1								| 255								| Fixed		|
| Fade In							|   153 | 1								| 255								| Fixed		|
| Fade Out							|   154 | 1								| 255								| Fixed		|
| Master Intensity					|   155 | 0-255							| 0-255								| Range		|
| Previous submaster tab			|   302 | 1								| 255								| Fixed		|
| Next submaster tab				|   303 | 1								| 255								| Fixed		|
| Toggle Submaster 1				|   182 | 1								| 255								| Fixed		|
| Toggle Submaster 2				|   183 | 1								| 255								| Fixed		|
| Toggle Submaster 3				|   184 | 1								| 255								| Fixed		|
| Toggle Submaster 4				|   185 | 1								| 255								| Fixed		|
| Toggle Submaster 5				|   186 | 1								| 255								| Fixed		|
| Submaster Go 1					|   187 | 1								| 255								| Fixed		|
| Submaster Back 1					|   188 | 1								| 255								| Fixed		|
| Submaster Go 2					|   189 | 1								| 255								| Fixed		|
| Submaster Back 2					|   190 | 1								| 255								| Fixed		|
| Submaster Go 3					|   191 | 1								| 255								| Fixed		|
| Submaster Back 3					|   192 | 1								| 255								| Fixed		|
| Submaster Go 4					|   193 | 1								| 255								| Fixed		|
| Submaster Back 4					|   194 | 1								| 255								| Fixed		|
| Submaster Go 5					|   195 | 1								| 255								| Fixed		|
| Submaster Back 5					|   196 | 1								| 255								| Fixed		|
| Submaster Page 1					|   197 | 1								| 255								| Fixed		|
| Submaster Page 2					|   198 | 1								| 255								| Fixed		|
| Submaster Page 3					|   199 | 1								| 255								| Fixed		|
| Submaster Page 4					|   200 | 1								| 255								| Fixed		|
| Subm. Intensity 1					|   201 | 0-255							| 0-255								| Range		|
| Subm. Intensity 2					|   202 | 0-255							| 0-255								| Range		|
| Subm. Intensity 3					|   203 | 0-255							| 0-255								| Range		|
| Subm. Intensity 4					|   204 | 0-255							| 0-255								| Range		|
| Subm. Intensity 5					|   205 | 0-255							| 0-255								| Range		|
| Submaster Run 1					|   385 | 1								| 255								| Fixed		|
| Submaster Run 2					|   386 | 1								| 255								| Fixed		|
| Submaster Run 3					|   387 | 1								| 255								| Fixed		|
| Submaster Run 4					|   388 | 1								| 255								| Fixed		|
| Submaster Run 5					|   389 | 1								| 255								| Fixed		|
| Submaster Run 6					|   390 | 1								| 255								| Fixed		|
| Submaster Run 7					|   391 | 1								| 255								| Fixed		|
| Submaster Run 8					|   392 | 1								| 255								| Fixed		|
| Submaster Run 9					|   393 | 1								| 255								| Fixed		|
| Submaster Run 10					|   394 | 1								| 255								| Fixed		|
| Submaster Run 11					|   395 | 1								| 255								| Fixed		|
| Submaster Run 12					|   396 | 1								| 255								| Fixed		|
| Submaster Run 13					|   397 | 1								| 255								| Fixed		|
| Submaster Run 14					|   398 | 1								| 255								| Fixed		|
| Submaster Run 15					|   399 | 1								| 255								| Fixed		|
| Submaster Run 16					|   400 | 1								| 255								| Fixed		|
| Submaster Run 17					|   401 | 1								| 255								| Fixed		|
| Submaster Run 18					|   402 | 1								| 255								| Fixed		|
| Submaster Run 19					|   403 | 1								| 255								| Fixed		|
| Submaster Run 20					|   404 | 1								| 255								| Fixed		|
| Submaster Stop 1					|   405 | 1								| 255								| Fixed		|
| Submaster Stop 2					|   406 | 1								| 255								| Fixed		|
| Submaster Stop 3					|   407 | 1								| 255								| Fixed		|
| Submaster Stop 4					|   408 | 1								| 255								| Fixed		|
| Submaster Stop 5					|   409 | 1								| 255								| Fixed		|
| Submaster Stop 6					|   410 | 1								| 255								| Fixed		|
| Submaster Stop 7					|   411 | 1								| 255								| Fixed		|
| Submaster Stop 8					|   412 | 1								| 255								| Fixed		|
| Submaster Stop 9					|   413 | 1								| 255								| Fixed		|
| Submaster Stop 10					|   414 | 1								| 255								| Fixed		|
| Submaster Stop 11					|   415 | 1								| 255								| Fixed		|
| Submaster Stop 12					|   416 | 1								| 255								| Fixed		|
| Submaster Stop 13					|   417 | 1								| 255								| Fixed		|
| Submaster Stop 14					|   418 | 1								| 255								| Fixed		|
| Submaster Stop 15					|   419 | 1								| 255								| Fixed		|
| Submaster Stop 16					|   420 | 1								| 255								| Fixed		|
| Submaster Stop 17					|   421 | 1								| 255								| Fixed		|
| Submaster Stop 18					|   422 | 1								| 255								| Fixed		|
| Submaster Stop 19					|   423 | 1								| 255								| Fixed		|
| Submaster Stop 20					|   424 | 1								| 255								| Fixed		|
| Submaster Go 1					|   425 | 1								| 255								| Fixed		|
| Submaster Go 2					|   426 | 1								| 255								| Fixed		|
| Submaster Go 3					|   427 | 1								| 255								| Fixed		|
| Submaster Go 4					|   428 | 1								| 255								| Fixed		|
| Submaster Go 5					|   429 | 1								| 255								| Fixed		|
| Submaster Go 6					|   430 | 1								| 255								| Fixed		|
| Submaster Go 7					|   431 | 1								| 255								| Fixed		|
| Submaster Go 8					|   432 | 1								| 255								| Fixed		|
| Submaster Go 9					|   433 | 1								| 255								| Fixed		|
| Submaster Go 10					|   434 | 1								| 255								| Fixed		|
| Submaster Go 11					|   435 | 1								| 255								| Fixed		|
| Submaster Go 12					|   436 | 1								| 255								| Fixed		|
| Submaster Go 13					|   437 | 1								| 255								| Fixed		|
| Submaster Go 14					|   438 | 1								| 255								| Fixed		|
| Submaster Go 15					|   439 | 1								| 255								| Fixed		|
| Submaster Go 16					|   440 | 1								| 255								| Fixed		|
| Submaster Go 17					|   441 | 1								| 255								| Fixed		|
| Submaster Go 18					|   442 | 1								| 255								| Fixed		|
| Submaster Go 19					|   443 | 1								| 255								| Fixed		|
| Submaster Go 20					|   444 | 1								| 255								| Fixed		|
| Submaster Back 1					|   445 | 1								| 255								| Fixed		|
| Submaster Back 2					|   446 | 1								| 255								| Fixed		|
| Submaster Back 3					|   447 | 1								| 255								| Fixed		|
| Submaster Back 4					|   448 | 1								| 255								| Fixed		|
| Submaster Back 5					|   449 | 1								| 255								| Fixed		|
| Submaster Back 6					|   450 | 1								| 255								| Fixed		|
| Submaster Back 7					|   451 | 1								| 255								| Fixed		|
| Submaster Back 8					|   452 | 1								| 255								| Fixed		|
| Submaster Back 9					|   453 | 1								| 255								| Fixed		|
| Submaster Back 10					|   454 | 1								| 255								| Fixed		|
| Submaster Back 11					|   455 | 1								| 255								| Fixed		|
| Submaster Back 12					|   456 | 1								| 255								| Fixed		|
| Submaster Back 13					|   457 | 1								| 255								| Fixed		|
| Submaster Back 14					|   458 | 1								| 255								| Fixed		|
| Submaster Back 15					|   459 | 1								| 255								| Fixed		|
| Submaster Back 16					|   460 | 1								| 255								| Fixed		|
| Submaster Back 17					|   461 | 1								| 255								| Fixed		|
| Submaster Back 18					|   462 | 1								| 255								| Fixed		|
| Submaster Back 19					|   463 | 1								| 255								| Fixed		|
| Submaster Back 20					|   464 | 1								| 255								| Fixed		|
| Submaster intens. 1				|   465 | 0-255							| 0-255								| Range		|
| Submaster intens. 2				|   466 | 0-255							| 0-255								| Range		|
| Submaster intens. 3				|   467 | 0-255							| 0-255								| Range		|
| Submaster intens. 4				|   468 | 0-255							| 0-255								| Range		|
| Submaster intens. 5				|   469 | 0-255							| 0-255								| Range		|
| Submaster intens. 6				|   470 | 0-255							| 0-255								| Range		|
| Submaster intens. 7				|   471 | 0-255							| 0-255								| Range		|
| Submaster intens. 8				|   472 | 0-255							| 0-255								| Range		|
| Submaster intens. 9				|   473 | 0-255							| 0-255								| Range		|
| Submaster intens. 10				|   474 | 0-255							| 0-255								| Range		|
| Submaster intens. 11				|   475 | 0-255							| 0-255								| Range		|
| Submaster intens. 12				|   476 | 0-255							| 0-255								| Range		|
| Submaster intens. 13				|   477 | 0-255							| 0-255								| Range		|
| Submaster intens. 14				|   478 | 0-255							| 0-255								| Range		|
| Submaster intens. 15				|   479 | 0-255							| 0-255								| Range		|
| Submaster intens. 16				|   480 | 0-255							| 0-255								| Range		|
| Submaster intens. 17				|   481 | 0-255							| 0-255								| Range		|
| Submaster intens. 18				|   482 | 0-255							| 0-255								| Range		|
| Submaster intens. 19				|   483 | 0-255							| 0-255								| Range		|
| Submaster intens. 20				|   484 | 0-255							| 0-255								| Range		|
| Submaster list change 1			|   595 | 0-255							| 0-255								| Range		|
| Submaster list change 2			|   596 | 0-255							| 0-255								| Range		|
| Submaster list change 3			|   597 | 0-255							| 0-255								| Range		|
| Submaster list change 4			|   598 | 0-255							| 0-255								| Range		|
| Submaster list change 5			|   599 | 0-255							| 0-255								| Range		|
| Submaster list change 6			|   600 | 0-255							| 0-255								| Range		|
| Submaster list change 7			|   601 | 0-255							| 0-255								| Range		|
| Submaster list change 8			|   602 | 0-255							| 0-255								| Range		|
| Submaster list change 9			|   603 | 0-255							| 0-255								| Range		|
| Submaster list change 10			|   604 | 0-255							| 0-255								| Range		|
| Submaster list change 11			|   605 | 0-255							| 0-255								| Range		|
| Submaster list change 12			|   606 | 0-255							| 0-255								| Range		|
| Submaster list change 13			|   607 | 0-255							| 0-255								| Range		|
| Submaster list change 14			|   608 | 0-255							| 0-255								| Range		|
| Submaster list change 15			|   609 | 0-255							| 0-255								| Range		|
| Submaster list change 16			|   610 | 0-255							| 0-255								| Range		|
| Submaster list change 17			|   611 | 0-255							| 0-255								| Range		|
| Submaster list change 18			|   612 | 0-255							| 0-255								| Range		|
| Submaster list change 19			|   613 | 0-255							| 0-255								| Range		|
| Submaster list change 20			|   614 | 0-255							| 0-255								| Range		|
| MIDI to DMX 1						|   208 | 0-255							| 0-255								| Range		|
| MIDI to DMX 2						|   209 | 0-255							| 0-255								| Range		|
| MIDI to DMX 3						|   210 | 0-255							| 0-255								| Range		|
| MIDI to DMX 4						|   211 | 0-255							| 0-255								| Range		|
| MIDI to DMX 5						|   212 | 0-255							| 0-255								| Range		|
| MIDI to DMX 6						|   213 | 0-255							| 0-255								| Range		|
| MIDI to DMX 7						|   214 | 0-255							| 0-255								| Range		|
| MIDI to DMX 8						|   215 | 0-255							| 0-255								| Range		|
| MIDI to DMX 9						|   216 | 0-255							| 0-255								| Range		|
| MIDI to DMX 10					|   217 | 0-255							| 0-255								| Range		|
| MIDI to DMX 11					|   218 | 0-255							| 0-255								| Range		|
| MIDI to DMX 12					|   219 | 0-255							| 0-255								| Range		|
| MIDI to DMX 13					|   220 | 0-255							| 0-255								| Range		|
| MIDI to DMX 14					|   221 | 0-255							| 0-255								| Range		|
| MIDI to DMX 15					|   222 | 0-255							| 0-255								| Range		|
| MIDI to DMX 16					|   223 | 0-255							| 0-255								| Range		|
| MIDI to DMX 17					|   224 | 0-255							| 0-255								| Range		|
| MIDI to DMX 18					|   225 | 0-255							| 0-255								| Range		|
| MIDI to DMX 19					|   226 | 0-255							| 0-255								| Range		|
| MIDI to DMX 20					|   227 | 0-255							| 0-255								| Range		|
| MIDI to DMX 21					|   228 | 0-255							| 0-255								| Range		|
| MIDI to DMX 22					|   229 | 0-255							| 0-255								| Range		|
| MIDI to DMX 23					|   230 | 0-255							| 0-255								| Range		|
| MIDI to DMX 24					|   231 | 0-255							| 0-255								| Range		|
| Cuelist tab 1						|   266 | 1								| 255								| Fixed		|
| Cuelist tab 2						|   267 | 1								| 255								| Fixed		|
| Cuelist tab 3						|   268 | 1								| 255								| Fixed		|
| Cuelist tab 4						|   269 | 1								| 255								| Fixed		|
| Cuelist tab 5						|   270 | 1								| 255								| Fixed		|
| Cuelist tab 6						|   271 | 1								| 255								| Fixed		|
| Previous cuelist tab				|   300 | 1								| 255								| Fixed		|
| Next cuelist tab					|   301 | 1								| 255								| Fixed		|
| Toggle Cuelist 1					|   272 | 1								| 255								| Fixed		|
| Toggle Cuelist 2					|   273 | 1								| 255								| Fixed		|
| Toggle Cuelist 3					|   274 | 1								| 255								| Fixed		|
| Toggle Cuelist 4					|   275 | 1								| 255								| Fixed		|
| Toggle Cuelist 5					|   276 | 1								| 255								| Fixed		|
| Toggle Cuelist 6					|   277 | 1								| 255								| Fixed		|
| Toggle Cuelist 7					|   278 | 1								| 255								| Fixed		|
| Toggle Cuelist 8					|   279 | 1								| 255								| Fixed		|
| Toggle Cuelist 9					|   280 | 1								| 255								| Fixed		|
| Toggle Cuelist 10					|   281 | 1								| 255								| Fixed		|
| Toggle Cuelist 11					|   282 | 1								| 255								| Fixed		|
| Toggle Cuelist 12					|   283 | 1								| 255								| Fixed		|
| Toggle Cuelist 13					|   284 | 1								| 255								| Fixed		|
| Toggle Cuelist 14					|   285 | 1								| 255								| Fixed		|
| Toggle Cuelist 15					|   286 | 1								| 255								| Fixed		|
| Toggle Cuelist 16					|   287 | 1								| 255								| Fixed		|
| DMX400 Toggle mode				|   564 | 1								| 255								| Fixed		|
| DMX400 master						|   306 | 0-255							| 0-255								| Range		|
| DMX400 background					|   307 | 0-255							| 0-255								| Range		|
| DMX400 Program Select				|   308 | 1								| 255								| Fixed		|
| DMX400 Speed						|   309 | 0-255							| 0-255								| Range		|
| DMX400 Blackout					|   310 | 1								| 255								| Fixed		|
| DMX400 Full On					|   311 | 1 (mousedown)<br>0 (mouseup)	| 255 (mousedown)<br>0 (mouseup)	| Button	|
| DMX400 Fade						|   312 | 1								| 255								| Fixed		|
| DMX400 FadeTime					|   313 | 0-255							| 0-255								| Range		|
| DMX400 Interval					|   314 | 0-255							| 0-255								| Range		|
| DMX400 Auto Change				|   315 | 1								| 255								| Fixed		|
| DMX400 Color Change				|   316 | 1								| 255								| Fixed		|
| DMX400 Same Color					|   317 | 1								| 255								| Fixed		|
| DMX400 Vivid Colors				|   318 | 1								| 255								| Fixed		|
| Command 0							|   319 | 1								| 255								| Fixed		|
| Command 1							|   320 | 1								| 255								| Fixed		|
| Command 2							|   321 | 1								| 255								| Fixed		|
| Command 3							|   322 | 1								| 255								| Fixed		|
| Command 4							|   323 | 1								| 255								| Fixed		|
| Command 5							|   324 | 1								| 255								| Fixed		|
| Command 6							|   325 | 1								| 255								| Fixed		|
| Command 7							|   326 | 1								| 255								| Fixed		|
| Command 8							|   327 | 1								| 255								| Fixed		|
| Command 9							|   328 | 1								| 255								| Fixed		|
| Command +							|   329 | 1								| 255								| Fixed		|
| Command -							|   330 | 1								| 255								| Fixed		|
| Command /							|   331 | 1								| 255								| Fixed		|
| Command @							|   332 | 1								| 255								| Fixed		|
| Command DMX						|   333 | 1								| 255								| Fixed		|
| Command SHIFT						|   334 | 1								| 255								| Fixed		|
| Command CLR						|   335 | 1								| 255								| Fixed		|
| Command BS						|   336 | 1								| 255								| Fixed		|
| Command ENTER						|   337 | 1								| 255								| Fixed		|
| Command history up				|   338 | 1								| 255								| Fixed		|
| Command history down				|   339 | 1								| 255								| Fixed		|
| Submaster toggle 1				|   615 | 1								| 255								| Fixed		|
| Submaster toggle 2				|   616 | 1								| 255								| Fixed		|
| Submaster toggle 3				|   617 | 1								| 255								| Fixed		|
| Submaster toggle 4				|   618 | 1								| 255								| Fixed		|
| Submaster toggle 5				|   619 | 1								| 255								| Fixed		|
| Submaster toggle 6				|   620 | 1								| 255								| Fixed		|
| Submaster toggle 7				|   621 | 1								| 255								| Fixed		|
| Submaster toggle 8				|   622 | 1								| 255								| Fixed		|
| Submaster toggle 9				|   623 | 1								| 255								| Fixed		|
| Submaster toggle 10				|   624 | 1								| 255								| Fixed		|
| Submaster toggle 11				|   625 | 1								| 255								| Fixed		|
| Submaster toggle 12				|   626 | 1								| 255								| Fixed		|
| Submaster toggle 13				|   627 | 1								| 255								| Fixed		|
| Submaster toggle 14				|   628 | 1								| 255								| Fixed		|
| Submaster toggle 15				|   629 | 1								| 255								| Fixed		|
| Submaster toggle 16				|   630 | 1								| 255								| Fixed		|
| Submaster toggle 17				|   631 | 1								| 255								| Fixed		|
| Submaster toggle 18				|   632 | 1								| 255								| Fixed		|
| Submaster toggle 19				|   633 | 1								| 255								| Fixed		|
| Submaster toggle 20				|   634 | 1								| 255								| Fixed		|
| Previous MIDI page				|   635 | 1								| 255								| Fixed		|
| Next MIDI page					|   636 | 1								| 255								| Fixed		|
| Release override gobo1			|   637 | 1								| 255								| Fixed		|
| Release override gobo2			|   638 | 1								| 255								| Fixed		|
| Release override gobo3			|   639 | 1								| 255								| Fixed		|
| Release override color1			|   640 | 1								| 255								| Fixed		|
| Release override color2			|   641 | 1								| 255								| Fixed		|
| Release override gobo1 rot.		|   642 | 1								| 255								| Fixed		|
| Release override gobo2 rot.		|   643 | 1								| 255								| Fixed		|
| Release override red				|   644 | 1								| 255								| Fixed		|
| Release override green			|   645 | 1								| 255								| Fixed		|
| Release override blue				|   646 | 1								| 255								| Fixed		|
| Release override amber			|   647 | 1								| 255								| Fixed		|
| Release override white1			|   648 | 1								| 255								| Fixed		|
| Release override white2			|   649 | 1								| 255								| Fixed		|
| Release override pan				|   650 | 1								| 255								| Fixed		|
| Release override tilt				|   651 | 1								| 255								| Fixed		|
| Release override shutter			|   652 | 1								| 255								| Fixed		|
| Release override strobe			|   653 | 1								| 255								| Fixed		|
| Release override intensity		|   654 | 1								| 255								| Fixed		|
| Release override iris				|   655 | 1								| 255								| Fixed		|
| Release override focus			|   656 | 1								| 255								| Fixed		|
| Release override zoom				|   657 | 1								| 255								| Fixed		|
| Release override prism			|   658 | 1								| 255								| Fixed		|
| Release override prism rot.		|   659 | 1								| 255								| Fixed		|
| Release override frost			|   660 | 1								| 255								| Fixed		|
| Release override frost2			|   661 | 1								| 255								| Fixed		|
| Cuelistbutton ...					|   662 | 1								| 255								| Fixed		|
| Remove from playback				|   663 | 1								| 255								| Fixed		|
| Pause sound2light					|   664 | 1								| 255								| Fixed		|
| Disable fixture					|   665 | 1								| 255								| Fixed		|
| Master spd +5%					|   666 | 1								| 255								| Fixed		|
| Master spd 100%					|   667 | 1								| 255								| Fixed		|
| Master spd -5%					|   668 | 1								| 255								| Fixed		|
| One group only					|   669 | 1								| 255								| Fixed		|
| Open cuelist						|   670 | 1								| 255								| Fixed		|
| Toggle Cuelist 17					|   671 | 1								| 255								| Fixed		|
| Toggle Cuelist 18					|   672 | 1								| 255								| Fixed		|
| Toggle Cuelist 19					|   673 | 1								| 255								| Fixed		|
| Toggle Cuelist 20					|   674 | 1								| 255								| Fixed		|
| Toggle Cuelist 21					|   675 | 1								| 255								| Fixed		|
| Toggle Cuelist 22					|   676 | 1								| 255								| Fixed		|
| Toggle Cuelist 23					|   677 | 1								| 255								| Fixed		|
| Toggle Cuelist 24					|   678 | 1								| 255								| Fixed		|
| Toggle Cuelist 25					|   679 | 1								| 255								| Fixed		|
| Toggle Cuelist 26					|   680 | 1								| 255								| Fixed		|
| Toggle Cuelist 27					|   681 | 1								| 255								| Fixed		|
| Toggle Cuelist 28					|   682 | 1								| 255								| Fixed		|
| Toggle Cuelist 29					|   683 | 1								| 255								| Fixed		|
| Toggle Cuelist 30					|   684 | 1								| 255								| Fixed		|
| Toggle Cuelist 31					|   685 | 1								| 255								| Fixed		|
| Toggle Cuelist 32					|   686 | 1								| 255								| Fixed		|

