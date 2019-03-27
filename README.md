# TourAR

YouTube Video Link :
Screen Recorded Video with Project explanation
https://youtu.be/JhsldZuPi60

Github Repository Link :
Apk- https://github.com/leenabhandari/TourAR-apk

1. Usecase / Abstract:

Although many efforts are taken to improve tourism by bringing in innovative ideas, we aren’t there just yet. Our idea is to enhance the tourism by leveraging Augmented Reality. We have created a mobile application for the same. On recognising an image of a monument (say Taj mahal), it will augment a 3D model of the same. The model is touch interactive i.e one can scale and move to see the details of the monument. There are numerous information boards installed at and around monuments but hardly anyone reads them. Therefore, the application supports a voice enabled chatbot for a better user experience. This idea helps in conveying the right information to the tourists and acts like a guide for the visitors. This would help in promotion and would lead to enhancement in the tourism eventually.

2. Introduction 

Currently, very few tourism places use guides apart from humans. Most of the tourists have to rely on books, wikipedia and other hoardings. Some places also have audio guides. And very few have started working on AR based apps for tourism which also suggests the feasibility of our idea.

We have built the prototype for Taj Mahal. On recognising an image (say on a brochure) of the monument, a 3D view is augmented on the cellphone screen. It is touch interactive i.e one can zoom in(using 2 fingers) and translate the monument model (using 3 fingers). More features guiding about various sections may be added. 
One can also see the time-lapse of Taj Mahal and see how it looks at different times of the day by just hovering over the image. Currently, predefined image targets have been used. However, using CNN (on Tensorflow mobile), user defined targets may be implemented.
Since the most convenient and fulfilling experience is of a conversation rather than reading or browsing text, a voice enabled chatbot is implemented. As for the prototype, questions similar to the following questions have been trained:
“What is the cost of the ticket?”
“Which is the best time to visit?”
“Tell me more details”
More features would be added eventually. Also, it can be supported by a database(such as firebase) for storing more information. 


3. Technology Stack 

Vuforia - AR Platform
Unity, Visual studio (C#)- Development environment
Wit.ai- Speech recognition, chatbot
Infinity engine (Speech Engine)- Text to speech
Blender- 3D models
LeanTouch asset- Touch interaction

4. Working Methodology –
Working
Image Targets have been set on Vuforia platform. Using which recognition is done and 3D model is augmented on the same. Timelapse is also augmented on recognition of a predefined image. LeanTouch is used to enable touch functionality.
The record button is used for recording and sending the voice to wit ai system. The response is sent in JSON format which is parsed to get the output. Based on that the application speaks the response. 



Images for recognition: (Available in the repo)



5. Conclusion
This is a graphic intensive project and it requires stronger hardware to build. And we were successfully able to build a prototype of what we planned to create. Further, more enhancements can be made such as making use of convolutional neural network to make user-defined targets, supporting a database for the chatbot to query, adding functionalities to make reservations for tourists, training chatbot with more data, etc. This idea would promote tourism and could be used as a successful advertising and awareness strategy to help the government and other businesses. 
