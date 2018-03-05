## Sharpen your Alexa skills

### Zdravko Danev

#### Sr. Developer @ AgileThought

#### E-mail: zdanev@gmail.com

#### Twitter: @zdanev

#### Code and Slides: http://github.com/zdanev/occ2018

---

### The state of AI, NLP, etc.

![smart speakers](smart-speakers.jpg)

---

### Dartmouth workshop

> We propose that a 2 month, 10 man study of artificial intelligence be carried out during the summer of 1956 at Dartmouth College in Hanover, New Hampshire. The study is to proceed on the basis of the conjecture that every aspect of learning or any other feature of intelligence can in principle be so precisely described that a machine can be made to simulate it. An attempt will be made to find how to make machines use language, form abstractions and concepts, solve kinds of problems now reserved for humans, and improve themselves. We think that a significant advance can be made in one or more of these problems if a carefully selected group of scientists work on it together for a summer.

-- John McCarthy, 1955

---

### "Time flies like an arrow"

> A grammar that pretends to describe English at all accurately must yield a structure for “Time flies like an arrow” in which “time” is the subject of the verb “flies” and “like an arrow” is an adverbial phrase modifying the verb. “Time” can also serve attributively, however, as in “time bomb,” and “flies” of course can serve as a noun. Together with “like” interpreted as a verb, this yields a structure that becomes obvious only if one thinks of a kind of flies called “time flies,” which happen to like an arrow, perhaps as a meal. Moreover, “time” as an imperative verb with “flies” as a noun also yields a structure that makes sense as an order to someone to take out his stopwatch and time flies with great dispatch, or like an arrow.

-- Anthony Oettinger, 1966

---

### Alexa and Echo

![echo devices](echo-devices-800.png)

- Echo is a hardware device ("smart speaker") device from Amazon
- Alexa is the voice personality behind the Echo devices

---

### User intereaction flow

![flow diagram](flow-800.png)

---

### Before you begin

Register for a developer account(s)

- go to developer.amazon.com and register for a free developer account
- (optional) create aws.amazon.com account

---

### Alexa Voice Service (AVS)

- cloud based voice-recognition and NLP service that powers Amazom Alexa and Echo devices
- can be used to voice-enable virtually any device (i.e. Raspberi Pi) for building home automation or other voice-enabled solution

---

### Alexa Skills Kit (ASK)

- Alexa Skills SDK
- Documentation
- Samples

---

### Types of Alexa skills

#### Custom skills

- Custom skills consume a web service that can be hosted anywhere and can be developed in any language.

#### Smart Home skills

- Turn on/off the lights, set thermostat, control entertainment devices, etc.
- All interactions are handled by the Smart Home Skill API.

#### Video skills

- All interactions are handled by the Video Skill API.

#### Flash briefing skills

- Provide content such as news for the user’s flash briefing. 
- RSS or JSON feed.

---

### Create Alexa skill

1. Provide skill name
2. Select skill type
3. Add skill invocation name
- Two or more lower case words
- Cannot be a lunch phrase (launch, ask, tell, load, begin, enable)
- Cannot be a wake word (Alexa, Echo, Amazon, Computer)
- Does not need to be unique
4. Add custom intent
5. Add sample utterances

---

### Testing your Alexa skill

---

### Deploying Alexa skill

---

### Links

#### Amazon Developer Portal
[http://developer.amazon.com](http://developer.amazon.com)

#### Alexa Developer Portal
[http://developer.amazon.com/alexa](http://developer.amazon.com/alexa)

#### AWS SDK for .NET
[http://aws.amazon.com/sdk-for-net/](http://aws.amazon.com/sdk-for-net/)

#### Alexa Skills SDK for .NET (Tim Heuer)
[https://github.com/timheuer/alexa-skills-dotnet](https://github.com/timheuer/alexa-skills-dotnet)