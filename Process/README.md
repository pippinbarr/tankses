# 2017-12-28 18:12, in which we begin thinking about this project in earnest

Having finished _Sibilant Snakelikes_ this month (though I'm still contracted (by me) to write some post-mortem things) it's naturally time to start a new project. Because I'm teaching CART 415 this coming Winter semester and because I've decided to teach the course based around Unity's official TANKS! tutorial, it makes sense to me to use this as an opportunity to further explore Unity in a formal way. Specifically, the idea is to create (yet another) "variations game" around the completed version of the TANKS! tutorial. This is related to what I'll be asking the students to do in the course themselves (create variants/perversions of the game according to four specified topics), but I'll want to find my own conceptual framing that will make it worth doing beyond the basic fact of familiarising myself further with Unity as an engine.

I found _Sibilant Snakelikes_ a really successful way to explore the expressivity of the Snake mechanics via remediation, and in particular I like that the process felt at least somewhat rigorous. I had an overall question I was answering, and the design tasks I set myself (the subgames) felt like they forced me to address the question from different angles, hopefully building to some insights into design in that context. I want to do something related to that effectively for Unity itself in this case. That is I want to turn my gaze away from specific design/expression oriented questions toward technical questions. I think.

TANKS! is a nice testbed or experimental "instrument" in that it represents a totally cliched and banal vision of what a videogame is and should be. It's polished visually and with audio, it's designed to be fair, it focuses on accessibility and usability, and so on. There are countless design and implementation decisions evident even during the tutorial sessions that show how "normal" TANKS! is, and I think that's a positive. For one thing, there's nothing wrong with making a solid little game. For another, the fact TANKS! centres around a movement and shooting mechanic feels like something it would be good to explore, and it's something I haven't really worked with before. For one more, TANKS! is premised on the ways in which Unity specifically works to create games, and given how dominant Unity now seems to be in terms of independent game creation, and exploration of that engine is well worthwhile.

My early thought, then, is that TANKS!ES (which cutely reads a bit like TANKSIES) would be focused specifically on the technical affordances of Unity. My first idea around this is that I would go through one of Unity's menu systems (perhaps the Create menu) and attempt to create a variation on TANKS! based on each of the available ideas in that menu. That would yield:

- Empty
- Empty Child (hard to imagine how one would distinguish this from the above?)
- 3D Object
  - Cube
  - Sphere
  - Capsule
  - Cylinder
  - Plane
  - Quad
  - Ragdoll...
  - Terrain
  - Tree
  - Wind Zone
  - 3D text
- 2D Object
  - Sprite
- Light
  - Directional Light
  - Point Light
  - Spotlight
  - Area Light
  - Reflection Probe
  - Light Probe Group
- Audio
  - Audio Source
  - Audio Reverb Zone
- Video
  - Video Player
- UI
  - Text
  - Image
  - Raw Image
  - Button
  - Toggle
  - Slider
  - Scrollbar
  - Dropdown
  - Input Field
  - Canvas
  - Panel
  - Scroll View
  - Event System
- Particle System
- Camera

Now, looking at that list explicitly I'm worried about being able to consistently address each concept. It also illuminates that the 'question' here isn't clear enough. Am I asking what the expressive power of each of these primitive elements of the Unity engine's "cast of characters" is? Am I asking how to reframe the entirety of TANKS! in terms of that single entity? A version of TANKS! where everything is a Sprite? Where everything is an Input Field? Or is it more ambitious in terms of potentials for reframing/reimagining the interactivity of the game? A version of TANKS! where you control all aspects of play with sliders? A version of TANKS! where you move the tanks around using Wind Zones? Is the question what the different parts of the engine "naturally enable"? Some of them interactive, some of them purely visual? Is it interesting to make a version fo the game in which everything is a cube and another in which everything is a sphere?

Do I take each element of the game as a concept to redesign TANKS! around? A sphere becomes a planet that reframes how the tanks navigate? An Input Field leads to a text-input-based version of the game with the players frantically typing in orders to their tanks? An Audio Source frames the game as audio only? Am I on shaky ground if I do something like that, or is this legitimately a kind of design exploration of specific tools provided to me by the program?

Note that the Assets folder has a separate set of possible things to Create:

- Folder
- C# script
- Javascript
- Shader
  - Standard Surface Shader
  - Unlit Shader
  - Image Effect Shader
  - Compute Shader
  - Shader Variant Collection
- Testing
  - EditMode Test C# Script
  - PlayMode Test C# Script
- Scene
- Prefab
- Audio Mixer
- Material
- Lens Flare
- Render Texture
- Lightmap Parameters
- Sprites
  - Square
  - Triangle
  - Diamond
  - Hexagon
  - Circle
  - Polygon
- Animator Controller
- Animation
- Animator Override Controller
- Avatar Mask
- Physic Material
- Physics Material 2D
- GUI Skin
- Custom Font
- Legacy
  - Cubemap

Another exceedingly dry list of possibilities. I wonder to what extent these two lists somehow capture the "heart" of Unity? The other thing that would be part of that heart would be the set of available Components, too. There are many, many of those, some of which recreate some of the above (e.g. an Audio Source is just a Component on a GameObject).

Thinking about my experience with _Sibilant Snakelikes_ it's important not to _ignore_ the target game of TANKS! in this case. You can't just abstractly think about how a Lens Flare might relate to game design, you need to think about how it might relate to game design in the context of TANKS! (A Lens Flare implies distraction and being unable to see properly, to me, which further implies some kind of disadvantage in the context of two tanks trying to kill each other.)

Do I need some extra philosophical/affective/psychological content to this whole thing? As in, should I have a simulataneous project of trying to redesign/rethink TANKS! in terms of commentary/thought about violence in games more generally? Should each redesign/intervention be about "defusing" the original game's cheerful killing? I guess the question here is that if we're talking about using specific engine features we need to use them _in service of a design aim_ and that design aim needs to be grounded in something that isn't just the technical element itself. You need to have _something you're trying to do_ whether it's to "make a fun game" or "convey tragedy" or "tell your life story". How do I chose that second, parallel element?

To what extent am I bound to keep the basic premise of TANKS! intact? Does the resulting game still need to be "two entities try to eliminate each other with projectiles" or am I taking the bones of this things and twisting them any which way? Can I turn it into a Walking Simulator with a single tank as a response to the prompt of "Terrain"?

That idea of each engine element being a "prompt" for design has something to it perhaps. That it's not about some overarching message ("violence is bad") but about responding as a designer/creator to the material at hand. But responding through a pre-existing frame (of TANKS!) rather than starting with nothing at all and trying to make a game "about the Terrain tool in Unity"? TANKS! then serves "simply" as a set of available design moves to be taken/dropped/enhanced/reduce/twisted as needed in order to shape something that is a designerly response to the material being addressed - like "Cube" or "Sphere" or "Custom Font".

A little flash in my mind just now of the level titles simple being the specific menu item selected seems appealing. Like "Physic Material" is the title of a level/game. It comes up in white on a black background. Etc.

(I did have a thought that these interventions could also be seen as potentially _cumulative_. That each intervention based on an engine part could be on or off in any given playing of the game itself. As such they couldn't be total refigurings of the game but instead ideas that alter the original game through their presence. That's quite a different possible direction. Then "Animator Controller" becomes something that, when activated during play, changes the game according to its powers. This reminds me a bit of my idea of creating Pitfalls that were in response to Become a Great Artist in Just 10 Seconds.)

I can tell I'm not entirely comfortable with this project yet. At the highest level of "make a game that uses features of the Unity engine to make variations on a basic Unity tutorial game" the project makes sense and seems to be about the expressive/designerly features of the Unity engine "as a material". But drilling down it's obvious that it's hard-to-impossible to actually _do design_ without other key structuring principles. You can't just illustrate the properties and potentials of the engine-as-material without some additional direction/constraints.

To some extent the idea here is to expose what difference the _fact this game is in Unity_ makes to its composition and possibilities?

One factor at the base of all this is: Pippin learning Unity. A big part of even wanting to take on a project like this is the thought of improving my abilities with this super powerful tool. Even reading the list of "things that can exist" illustrates to me how far off understanding these things I am. There are so many tools that make no sense to me at all, to the point that I'd have to learn a lot just to being to think about how to design with them as the "primary material" in a redesign of TANKS!.

Is "Empty" just a version of the game with no represenation at all? Or is it a version of the game that is empty, with nothing in it? At which point it's kind of just a gag?

If the principles of TANKS! are

- Move skillfully so as not to be hit by enemy shells
- Fire your shells skillfully so as to hit your enemy
- (Observe/evaluate where your enemy is and where you are, and what the terrain looks like to facilitate the above)

Then is the idea that we think about how the materials of Unity can play into this core dynamic? Movement and Shooting? At which point do we come up with ideas such as something I've written down for CART 415 where "light" is reframed as your weapon? Could it be reframes as a form of movement?

If the verbs here are MOVE, SHOOT, EVALUATE (which is starting to get toward stuff written about Donald Norman in terms of affordances and those gulfs of execution and evaluation?) then is the project to find ways in which those verbs can be impacted by the aspects of the engine? At present, for example, there is an emphasis on components of the engine being levered toward making those verbs accessible, usable, fair - but what if we reframe those verbs to prioritise the potential of specific elements of the engine?

There's perhaps something there. But is it just that something like "Point Light" is inspiring in a way that something like Sprites > Hexagon really, really isn't? And isn't it true, by the way, that not every possible engine part makes any sense to choose as an intervention (on its own)? Like "Canvas" on its own does squarely nothing, is invisible, etc.

Well I suppose this has been at least somewhat productive. I need to think more though. And I will.

---

## 2017-12-30 15:55, in which we write some more words trying to find our way to something to hold onto

__What am I even doing?__

Let me say that this is kind of interesting as project because I'm "in The Method" right now without really knowing much of anything about what it is beyond 'variations based on TANKS!'. I guess, to be fair, _Sibilant Snakelikes_ began in much the same way, with only a vague idea of remediation of existing games. Here I have a similarly vague concept of 'thinking about the Unity engine' or something along those lines. So it's not like I haven't been here before. Nonetheless it's uncomfortable and somehow feels different (even if perhaps it isn't).

---

__Conversation with materials?__

One thing that I think this project may represent a chance to try is using Git branches to represent exploratory prototyping? In particular, because I'm not _that_ familiar with Unity as a tool, it may well be the case I need to feel things out with the materials more than I normally would - I can't necessarily 'think in Unity' in the same way I can 'think in Phaser' (or even 'think in Unity+First Person+Architecture'). And indeed the point of this project is, to some extent, a conversation with materials. As such we're kind of talking Reflective Practitioner? I should probably re-read at least my notes on that as a kind of grounding for this project. (Just like I read remediation and metaphor literature for _Sibilant_ right? Ha ha. As in, I didn't do it then so let's not assume I will now.)

But, ha has aside, maybe that idea of a "conversation with materials" is actually a useful structuring principle for this? Above I wrote about the idea of the combination of basic verbs of play (move, shoot, evaluate) and how they might interact with the potential of specific game engine parts (like points lights and UI canvases).

So can I set this up as a kind of triad? (Hi Bart.) Like there's the Designer (me), there's the material (Unity) and there's the... what, conceptual material? (TANKS! design). Triangles. Subject Tool Object?

This is at least feeling a bit like a frame? Then you could have a Git branch that represents a specific attempt at a conversation with specific material properties of Unity. So you open a branch that is about Light (or specifically Point Light?) and then you take the framework of TANK! and you look at it for affordances to introduce (Point) Light in a way that... what? There's a kind of creative/interpretive leap there that feels weird.

Like is it okay to say "well I'm just going to come up with something cool in TANKS! based on this element of the Unity engine"? I guess it's okay so long as the "something cool" is documented through its discovery and reasoning. I need to be able to think through _how_ the material and the design work together.

And what question is being asked and explored here? That's important. Yes you can be having a conversation with the materials, but what are we learning from that - especially given my status as a non-expert in the context of the materials specifically (even if I'm in some sense an expert in design). Look, what if we take a specific example that I've already thought about making in the context of CART 415 (which is another feature in this whole thing) and think about it. Odd because I haven't actually explored this in-engine, but still let's see...

---

__Light, by way of example__

So if I were to take _Light_ as an input/material (for now let's not worry about whether I should think in specific types of light). One idea I have is that the scene is unlit. The shells are replaced by Point Lights (fine with Real Time lighting). When you fire a shell it lands and instead of blowing up it stays there, illuminating the scene where it is. So we're talking about an interaction between SHOOT and LIGHT in this case. We could further imagine an idea that you take damage from light, so if you're within its sphere of illumination you're being damaged (could do this with a Trigger Collider that same dimensions as the sphere of illumination). This creates a relationship between SHOOT and EVALUATION that's different - you can't see your opponent or yourself unless in the light, but if you go into light to figure out where you are, you get damaged and potentially die, creating a trade-off and a potential need to a greater kind of 'kinesthetic awareness' on the part of the player to be able to drive around in the dark.

This idea could be complicated easily by layering more rules. Like the tanks could fire coloured lights such that they're not damaged by their own lights, so they could use them to figure out where they are AND to attack their opponent.

---

__Let there be light?__

But the instant you start thinking that way you have to ask yourself: _what is this about?_ The above idea is clearly an extension of/intervention into the TANKS! design that is inspired by LIGHT. It clearly leads to a related but different form of play. It might even be fun/entertaining. But what is it telling us? Why that specific kind of intervention and not something completely different? Why not Light in terms of dramatic illumination in the style of German Expressionist Cinema, for example? Why one approach and not another?

This raises one question/idea: rather than creating a game that has one version based on one part of the engine, what if you made TANKS!ES: LET THERE BE LIGHT, for example, and made a suite of games that were entirely about using Unity's lighting system to create variations on TANKS!

Again there's a suspicious lack of rigour and, somehow, of intelligence here? But is that somehow okay? What if I just suck it up and say, well, I'm going to make a set of variations of TANKS! all of which use Unity's lighting capacity to create new gameplay affordances and aesthetic possibilities? And I learn what I learn along the way? Still feels pretty loosey goosey? Not much to grab onto there? I'd learn plenty about just implementing different shit in Unity, I might make some semi-entertaining games, but does this _tell me anything about light in Unity_? It's not clear that it does.

If I did use this higher level strategy I'd have

- TANKS!es: Light
- TANKS!es: 3D object
- TANKS!es: 2D object
- TANKS!es: Audio
- TANKS!es: Video
- TANKS!es: UI
- TANKS!es: Particle System
- TANKS!es: Camera

Which is starting to seem like it could be kind of intriguing? Like how to refactor a simple game (TANKS!) by using a specific form of material that a game engine deems _fundamental_ to its ontology. These are the things that exist as kind of first-order entities inside Unity. To then attempt to work with those fundamental materials in order to explore how they could lead to different forms of play is an interesting idea. In this case TANKS! is just a kind of patsy - it's not that important that it's TANKS! specifically (other than it being a kind of Ur game).

It lacks a bit in terms of being TOTALLY FORMAL in a way I'm fond of, but it's no less formal than something like PONGS, which had no objective other than "what small changes can I introduce to Pong in order to make it a different game?". And PONGS was revelatory in a lot of ways. Splitting this out into multiple different games makes the task seem more interesting to me. Rather than having the "one true Point Light" game, we have a whole bunch of different Light games that seek to explore the design affordances of Light, at least in the context of a highly traditional videogame.

Okay this is beginning to sound like something I believe in.

I'm all like, "Hi materials, I'm Pippin. I'd like to get to know you better."

---

__Ugly Piece of Shit Behemoth?__

I think I'll start with Light.

I'm now realising I need separate repos for each of these games? DO I? Or do w... yes, ... well...

No maybe I don't unless I'm worried about it becoming gargantuan? Technically all these approaches use the same underlying code and assets (except 3D object which will use others presumably). So I could build them all in the same project but then create separate executable RELEASES which I release over time.

I'm kind of stressed out about file management with Unity after _v r 3_ became such an ugly piece of shit behemoth.

In my dreams this whole thing works because I'm ultimately building on top of TANKS! and TANKS! on its own is something like 187MB as a project, which is not by any stretch of the imagination overly enormous. And actually somehow SOMEHOW 76MB of that is just in the lighting for a single scene? Raises the question of whether scene lighting is going to be horrible. BUT if I switch entirely to realtime lighting that becomes a non issue? But these are the kinds of questions I think I need to ask as practicalities.

Note that this isn't in terms of just making the game in general, because who really cares how large it gets. These are questions that _The Method_ requires me to ask. Because I need to be able to make the source of the thing available. Not so much for open sourcing (though that's a nice thing to think and care about) but because I need the commit history and for that to work the whole thing has to fit online properly. And therefore the repo needs to be under 2GB or so. Now obviously that's not a problem here, but I end up concerned about the repo being svelte or something. Haha. Harharhar. har.

Okay so there's a boring step at the start which is creating the minimal project that successfully represents the Unity Tanks Tutorial final outcome with the fewest possible files in it. And from there I can being with Git branches for each separate approach (e.g. Point light shells or whatever) and then merge them as successful when they're not (I guess I only merge when their scene 100% works?). Have to be careful about prefabs and so on and not changing them just for a single version - if I seriously need a prefab to change I should create a new one.

Those sorts of emerging 'rules' for development are part of this whole thing and are important. The desire to kind of maintain the purity of the initial project is important. As in, ideally if I'm making a project out of Light then I should only really be changing things related to light (e.g. adding lights, changing the overall lighting, changing scripting in relation to lighting, etc.). That's quite a nice constraint for me really and should make the rules of design a little clearer and the 'conversation with materials' a little easier to hear. If I may. I may.

Alright kid, I think you could start this game. And if you start this game you're effectively preparing for CART 415 because talking about this could actually end up being the main form of lecturing for me personally and my main contribution to discussion. I guess I don't know if I'll manage to go at at their pace? That's a different concern though. That's fine. But this does make me notice that I'll need a separate Unity project in which I can build versions of TANKS! in relation to weekly discussions. They'll be significantly more hacky that what I attempt to produce for my releasable version.

---

__Titling?__

TANKS!ES is the base name. I think currently that it makes the most sense to release differnet suites of variations as completely separate builds, rather than trying to release one megabuild that I update over time with 'DLC'. So

- TANKS!ES: LET THERE BE LIGHT! (LIGHT)

? If I want to have kind of comedy titles? Better than the boring alternative of just literally having the Unity Create Menu title. Yeah. So then...

- TANKS!ES: (SOUND)
- TANKS!ES: (3D OBJECT)
- TANKS!ES: (2D OBJECT)
- TANKS!ES: I AM CAMERA! (CAMERA)
- TANKS!ES: (UI)
- TANKS!ES: (PARTICLE SYSTEM)
- TANKS!ES: (VIDEO)

Actually as I try to come up with comedy names I'm kind of fucking failing and I suddenly wonder if the boring alternative is better?

- TANKS!ES: CREATE > LIGHT

Just straight up referencing the literal Unity Materials in question? Pluralise?

- TANKS!ES: LIGHTS
- TANKS!ES: CAMERAS
- TANKS!ES: AUDIOS < that kind of sucks
- TANKS!ES: USER INTERFACES
- TANKS!ES: 2D OBJECTS
- TANKS!ES: PARTICLE SYSTEMS

It mostly works okay. "AUDIOS" sucks. Bleah.

---

__How much is enough?__

Question: how many variations do you need to consider one of these games done? Do I set a hard limit to reach in every single one, like 10? Do I just "feel it" and the different things have different numbers of engagements? I think the latter is probably more fair. But maybe a minimum to avoid having a single 'variation'? Need at least, say, five versions in order to be able to see some kind of conversation between versions and discern some kind of ... knowledge-thing... from them... oh god writing.

Let's say (for now) a minimum of 5, no maximum.

---

__How will design proceed?__

One nice thing here is that because I legitimately don't know so, so much about Unity, I'm going to need to really do the conversation with materials thing more fully and immediately than usual. Normally there's of course a conversation with Phaser as I work out finer points of design via development, but generally speaking I can "think in Phaser" as I design such that I can write a bunch of design ideas based on knowing the kind of thing I can achieve. Here that's not really true, so it's likely a significant amount of the design process is going to be

- Sitting in the engine trying stuff out
- Reading the actual documentation of the Unity elements seeing what's possible (especially in terms of the scriptable properties of these things)
- Probably looking up what other people have done in terms of those elements

Honestly I'm quite excited by this project at this point. I think it has real merit as an exploration of the engine as material and I think it's experimental form is pretty legitimate.

---

__Next steps__

- Create minimal version of the TANKS! project (useful for CART 415 too)
- Set the repo ... well it's already in motion so that's fine
- Start playing around (perhaps by making that first version of the game)

I suspect that actually building out a light-based version of the game is going to throw me back into some interesting/trouble considerations of the actual underlying concept here, so I'll look forward to that potential agony when it comes.
