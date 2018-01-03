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

---

## 2017-12-31 10:10, in which I've officially created the base Unity project with TANKS! in it and I think about how even that was surprisingly stressful

Okay, so I bit the bullet and created the base version of the game. That is, it's the Unity TANKS! tutorial CompleteGame setup. I deleted all the stuff that was the incomplete versions from the setup so I didn't commit them as they're not of interest in this context. But also...

__LightingData__

One of the things that stresses me out with Unity + Git is the size of the projects. I don't know if it's a stupid worry (it might be), but I fret that the whole thing will become massive and unmanageable and eventually I won't be able to upload it anymore. Now, TANKS!ES isn't likely to fit that bill I don't think? There's aren't masses of assets to put into the game, which are the big space-takers - though there will inevitably be a bunch of audio and 3D and 2D assets that will have to go in I guess... but presumably not maaaaaaassive? Well I suppose that's a question that will come with time.

When I was checking the actual size of the folder for the game I ended up sleuthing around to see what was big. And one of the big things is the LightingData for the CompletedGame scene. Initially I felt like this was unnecessary/redundant because the game uses Realtime Lighting. So I deleted it thinking it made no difference. But of course when I played the game it was a bit darker now, so clearly the LightingData was for something (I mean, it's kind of obvious that it would be). So I looked up LightingData a bit and found that because the game uses Realtime Precomputed GI, if you want precomputed GI you still have to Generate Lighting and therefore generate a (large-ish) LightingData file. Given that I'm going to end up with a bunch of scenes in this project (like as many as 60+???) it seemed like that could get out of hand quickly... like 1GB of lighting data or something? There's another part of me that wonders whether Unity can tell if you have duplicate or related lighting data and therefore won't actually recompute it for scenes where it's not relevant? But any changes to the 3D world and any changes to the lighting would presumably necessitate distinct LightingData files, so it could still be big.

My solution for now has been to delete the LightingData and to rely entirely on Realtime light, no precomputation. It may well turn out there are major reasons _not_ to do that, but the advantage here is that if it's a problem I can just generate the lighting and it will be okay. The big risk seems to be around expensive computation during play that could create lag, so I'll just monitor that as I go along. I'm also perfectly willing to believe I'll see some weird fucked up lighting because of this... and again, I'll deal with that when it comes to me.

This _isn't_ especially interesting in terms of design right now, but it's a good illustration of the complexities of learning a new system, and the complexities of the many interlocking parts involved in a project like this... from Git to GitHub to Unity to LightingData and so on. Have to be able to hold it all in your head to some extent _from the beginning_ so as to make decisions that don't fuck you over later on. So, I'm trying mom.

__CART 415 and project organisation__

This project is intimately related to my CART 415 course this year in that I'm asking the students to pursue a similar kind of experimental exploration of the Unity engine in the context of the TANKS! tutorial game. I'm not asking them to do it in the same way or spirit as me and I'm not asking them to document to the insane level I'm favouring here, but TANKS! in Unity is going to be our core object of study.

To that end I initially duplicated my TANKS!ES project folder to have a version that I'd do CART 415-related manipulations in, but now I'm wondering about that. Given that the CART 415 project and discussion is around _exactly what I'm doing for TANKS!ES_, would it not make sense to do my explorations of ideas for CART 415 _in the TANKS!ES_ project. Otherwise I'm effectively splitting the same thinking and investigations artificially in two, and in terms of The Method, that seems like it could be problematic. There's no real distinction between me making exploratory versions of TANKS! to show and discuss with the class and me making "proper" versions of TANKS! that will form the games/levels of TANKS!ES, right?

I guess my only concern is about a kind of profusion of files and mess in the project that could get out of hand, but perhaps that can just be managed by being careful with folder structures. Notably it would make sense for me to separate out Prefabs, Scripts, Scenes etc. for the different iterations of TANKS!ES. And in terms of CART 415 the four projects are basically versions of TANKS!ES I'm thinking about anyway... "Lights, Camera" correspond to two of my versions, "Sound" corresponds to one, "Space and substance" corresponds (I guess) to "3D Objects" and "Interface" corresponds to UI (along with some other scripting). I guess the biggest difference I see in there is just that I'm intepreting "Interface" to include controls for CART 415, but I don't intend to do any of that in TANKS!ES (it's not implied by the Create menu I don't think).

So I guess my thought is that every new Scene is a _branch_ in the repository (so I desperately have to fucking remember to actually create those branches oh my god). And this would go for experiments to show the class as well as more designed ideas to implement for TANKS!ES proper. And they get merged into the main project when they're done (or done enough to be considered a specific part of the project), or never merged if they're not useful for whatever reason. (It would also be possible to do work that I don't actually want in the project in branches that I could switch to with SourceTree during class?)

Or another idea here is that CART 415 experiments are _perpetually_ in a CART 415 branch of the project, and that they then sometimes no doubt feed into branches that are for actual games to build? I don't actually know what a good structure is here. The experimentation for CART 415 seems like it's reflective of a specific level of development for TANKS!ES, more feeling your way, trying out cheap tricks that might be developed further (because obviously week to week I'm not going to have time to flesh out all these possibilities - I can only really attempt things that are relatively simple).

So should there be an 'explorations' branch from the beginning that contains all of the exploration stuff, and then other named branches would be specifically for versions of the game I'm looking to merge into the main project? That kind of makes sense? Definitely going to need to use SourceTree from here on. Fine. I will. (It's better for The Method anyway in terms of the ability to quickly view specific commits.)

Yeah okay, so there thing would look like (oh wait I think maybe an explorations for each subgame makes sense to keep them a bit more organised?). The explorations branches would _never be merged_. The subgames branches would be merged when they were done (enough) to become part of the master (not clear to me when that moment is, but I guess I'll feel it out). So the branches are...

- master (the project itself)

- light-explorations
- camera-explorations
- ...

- light-darkroom-sex-tanks (or whatever, I mean that's a hilarious idea though, whoa, but this would be an actual version of a game for the light collection - I'd use the prefix just to be organised)
- ...

This is all sounding kind of daunting and huge as a project at this point, but I need to remember that actual individual games for the collections are _not_ meant to be that insanely big and details.

__Ready, player one?__

With that, I suspect I'm ready to actually begin on this beautiful journey and just start seeing what happens. At a certain point you do have to just Let Go Let God and suffer the consequences. There's no question I'll have calculated badly wrong about various of the ideas here and that certain aspects of the project will be a nightmare. A main guiding light here, weirdly, is just being able to track and report on those failures I expect to have. More than anything I just don't want the repo to get so fucked up that it's no longer possible to view it and understand what's happening.

One great thing here is that I'm introducing an extra level of detail with the branching which I'm hopeful about (as well as all the Unity learnin' obviously). This will be a chance to see how Baby's First Branching relates to the The Method world. We all have an assumption it's a positive, but nobody has really tackled it in a project so, here I am, on the front lines, stepping on mines. For you, the viewer.

That's it. I've written inordinate amounts already about this game I haven't started making, but I think I've written myself into a place of at least understanding what's ahead of me and what I'm looking to achieve. Hi. It's me. Your son.

---

# 2018-01-01 18:32, in which I write what I imagine to be a post for my site summarising this new project

(Posted.)

## New Project: TANKS!ES

The New Year has begun and I'm thinking through the new game project that's going to occupy me for the next little while. For me, it represents an interesting constellation of concerns that manage to tie together my teaching and my research and multiple levels, so that's fun?

So, the game (or rather, the overall series, as this will be a series work) is called _TANKS!ES_. As you might imagine from the titling, it's me taking on another variations-oriented project. The minimal description of the project is that I'll be making variations of the game that is the result of Unity's excellent [TANKS! tutorial game](https://unity3d.com/learn/tutorials/s/tanks-tutorial). I've personally done that tutorial about three or four times now because I find it really helpful in terms of a sensible Unity workflow and seeing a decent survey of how Unity works. In the case of _TANKS!ES_, of course, it gets a bit more complicated. There are a number of streams of thought coming together for this project:

__Formal variations__. I find the process of working through distinct variations on a game to be a hugely generative and informative way to think about videogame design and videogame composition and videogame aesthetics and so on. As I've made more and more variations, I've tended to want more serious formal constraints on the process and I think in general having 'rules' (like a specific game I'm remediating in _[Sibilant Snakelikes](https://pippinbarr.github.io/sibilant-snakelikes/)_, say) leads to a more interesting project that can be thought about more deeply. In the case of _TANKS!ES_ the formal variations are based around the Unity engine itself, as that's my subject of experimentation here. Specifically, I'm going to create a series of collections of variations based on the top level of Unity's _GameObject_ menu. That is (excluding Empty Object and Empty Child for now) 3D Object, 2D Object, Light, Audio, Video, UI, Particle System, Camera. The idea will be to create variations on the _TANKS!_ tutorial game that respond to the implications and possibilities of each of those fundamental ontological categories in Unity. (Obviously I could talk about this at greater length, but that will do for now.)

__CART 415__. This semester I'm teaching my Game Studio course in my department at Concordia University. Year to year I've never completely settled on a way to teach the course other than knowing I want it to be an approach to experimental game design for the students. In the past I've perhaps pushed too hard on experimental being kind of aggressively obtuse/difficult/unfun, I guess because my work can trend that way. This time through I want experimental to be about the process and way of thinking. As such, my daring ploy here is that the students will work on projects related to _TANKS!ES_ - they'll take on that same challenge of responding to the engine and thinking creatively with the "materials" that Unity provides. This will give us an opportunity to really discuss the engine, game design in conversation with technology, related references, and so on. I'm quite looking forward to it.

__The Method__. I've written before about the fact that I'm trying to develop a rigorous method for process documentation and analysis in the context of game design that could stand up to scholarly scrutiny. That's hopefully-soon-to-be-funded project called [Games as Research](http://gamesasresearch.com/) I'm working on with Rilla Khaled and Jonathan Lessard in my department, and especially in conjunction with our work in the [Technoculture, Art, and Games (TAG) Lab](http://tag.hexagram.ca/). _[Sibilant Snakelikes](https://github.com/pippinbarr/sibilant-snakelikes)_, my most recent game, was an attempt to grapple really seriously with some of the techniques we're thinking about for the method - most notably a process journal (which I've been doing for a while), but also a more formal and detailed approach to writing Git commit messages that tries to explore design decisions in conjunction with their technical implementation. For _TANKS!ES_ my plan is to take the method a step further by thinking through how Git _branches_ can be intelligently used to reflect process and design. I only have early ideas for how I'm actually going to tackle this, but it should be an adventure.

It's kind of weird feeling that there's this quite substantial apparatus (The Method) and co-design (the class) going on with this project, but that's also what will hopefully make it an interesting thing to pursue. Because of the scale here I'm not really sure how long it's going to take to work through all the GameObject menu elements. It may be that I release one (I'm thinking I'll start with _TANKS!ES: Light_) and then take a break to make something else to return to it. We'll see.

Anyway, that's the current project. The [TANKS!ES GitHub repository](https://github.com/pippinbarr/tankses) is public and live and includes an already rather wordy [process journal](https://github.com/pippinbarr/tankses/blob/master/Process/README.md) if you want to immerse yourself in my early concerns about the direction of the project and its relationship to method and teaching.

See you on the other side.

---

# 2018-01-02 09:24, in which I fret some more about the principles of design for this project

I've contemplated some vague images in my mind of versions of the game for Light for example

- Rather than being damaged by light, you fire lights to illuminate the world and understand it?
- You fire pointlights that stay on the ground and if you drive through them the light sticks to you (either the point light or even changing emission of your tank's material?) - I guess this is 'just' a representation of damage?

Even in this brief flirtation with other design possibilities I'm running into a formal issue. Which the question of whether the underlying game should be kept (relatively) consistent or not. Like, TANKS! is pretty unavoidably about killing your opponent with projectiles, right? To what extent is it okay for my variations to deny that basic principle? As earlier, the verbs here are move, shoot, evaluate - am I honour bound to think about my variations/interventions in those terms? Can I _negate_ one or more of them in a design?

This speaks to a possibly more grounded question around the "materials" aspect of all this.

If the idea here is to take a _specific material_ like Light and intervene in and with it to create a variation, should I be aiming to _only_ intervene in and with that material? Like, in the Light versions of the game, am I only working with gameobjects that are Lights, the Lighting view in the Inspector, and Lighting-relevant API code in scripts? That's a very striking limitation and it's pretty appealing in terms of answering questions... but does it end up being so restrictive that you can't do something "interesting"?

And what is "interesting" anyway? The point of the project is about a conversation with materials. What if they're boring conversational partners? What if they don't want to talk to me? Ha ha. But seriously...

Re: the whole question of the Tank Ur-Game being about shooting... well, one thing we could say in the context of an engine-oriented take on this is that we're really talking about moving objects, projectiles, and reactions to those projectiles. As such it's not necessarily the case that we have to talk about destruction/death/killing. A game of catch or ultimate frisbee or basketball has the same principle ideas. At close range you can even think about projectiles as simply _giving_ something to someone else.

BUUUUUUT those kinds of potential changes could easily involve changes to code _not_ directly related to the material in question.

So, the question is about the kind of conversation we can have perhaps. Is it purely restricted to the language of the specific material, or is it about the larger conceptual space that the material allows us to think about?

But, devil's advocate, is there something cool about keeping the basic principles of the game (projectiles unto death) stable? It's a funny fuck you to my personal preferences in design?

More on this later.

---

# 2018-01-02 13:00, in which more thinking about the implications of GameObject-Oriented Design resulting in an acceptance of the most constrained version of the project

The appeal of being locked into making changes that literally only touch on the GameObject in question is that it is a very, very clear constraint that, in turn, makes the experimental quality of the project semi-rigorous. The project becomes a work about the affordances of _only that part of the engine_ (in conversation with the specific setup that _TANKS!_ represents). It allows me to be clear about what I can and can't do as a designer and maker in this space (it defines the space to a large extent).

_But_ that level of constraint, and particularly not being able to shift the meaning of the underlying game (tanks killing each other) means that a great deal of potential expressive range would be lost. Lighting, for example, has a huge amount of affective potential, but some of that affective potential exists specifically in relation to other aesthetic forms. For example, light reveals information - but the _kind of information revealed_ has a huge impact on the experience of it. If we're strict, the main things light can reveal in _TANKS!_ are the tanks themselves (relevant to knowing where you and your enemy area, making it more or less difficult to shoot them and the environment (which is a set tableau of a desert-y environment with oil derricks and non-descript buildings). "Revealing information" as a quality of light would presumably be significantly more interesting if you could _choose the information itself_.

So by way of example, if you wanted to create some kind of narrative property you might want to write things on the environment which can then be illuminated in some way by the tanks (whether through headlights or launched shell-lights or something else), say with UI Text objects. But in the "strict interpretation" of this project, you couldn't really do that because UI Text is not a Unity GameObject in the Light category. Similarly you couldn't change the architecture of the level to be more supportive of German Expressionist lighting because 3D Object is not the topic here.

There's a pretty clear sense in which restricting yourself to a single GameObject in the ontology of the engine ties you to highly limited game design. I mean, one of the much touted things about game design/making is that it's an amalgam of all these different disciplines and ideas and that they work in concert. By only working with Light and Light Alone you can't actually explore all the possibilities that Light affords in the context of game design.

On the other hand, if I allow myself to "start with Light" or "focus on Light" and then draw in other redesign/reimplementation ideas on top of the base game, how rigorous can the project really be? It starts to look a bit too much me just doing whatever? How would I formally tie the design to the materials once the materials become highly varied?

Could be that the division into Unity's ontological categories is just a weird division? _Get X Avoid Y_ was a rigorous game in the sense that I _only_ worked with the visual qualities of the game (along with the resulting physical/gameplay qualities of those visuals). But that's a different kind of dimension to what I'm working with here. Unity's ontological entities - Light, Camera, Particle System, and so specific in a lot of ways that they might be less expressive that you might want?

I do have a sneaking suspicion here that I'm a) just wasting time because I'm scared to start (almost certainly true) and b) not giving myself enough credit in terms of ability to be creative within such tight constraints and c) getting too attached to the idea of making "good games" in this mode, as opposed to treating it as a form of experimentation.

So a reminder: as ever, this work doesn't have to be "good" in a universal sense. The _project_ is good and important, the games may or may not be.

All that is to say that I think I begin with the most constrained version of this idea. Only Light. And if it turns out to suck too much, I will learn from that and expand, abandon, or complete the project as perceived necessary.

---

# 2018-01-02 17:40, in which Pippin responds to the experience of using his first branch to create a first (minimal) variation

Okay. So that was pretty stressful as it involved on taking on many levels and aspects of the project all at once. On the plus side I'm still here and to some extent conquered a number of issues. On the minus side it didn't leave me feeling all that excited about the overall project. Hopefully that will pass. So let's consider what happened (bearing in mind there's an entry in the commit for that version in its branch - `experiments-light`)

__Branching__. So, I did my first ever intentional branch in a Git project ever (lame, I know, but here we are). I named it `experiments-light` to reflect the idea it will contain general experimentation with lights in Unity in a series of scenes. The idea is that this will _not_ be integrated into the master because it's pure experimentation. It worked in the sense that the branch now exists and I committed to it.

__Branching and the journal__. Issue: The process journal is project wide and so should be branch-agnostic. As such I probably _always need to commit it to the `master`_ which is going to be a shitter to remember. Maybe the fact I'll have to switch branches semi-constantly will get me real comfortable with brances? That would be nice. Just for practice, I'm going to make sure I save this text and switch the project back to `master` to make sure I commit this in the right place (and to see what happens to this file when I switch...) Okay well I managed to do it so that there seem to be no major disaster. I guess a weird thing is just that each branch will just have a process journal frozen at the time the branch started. Can I merge across single files? Probably? Do I want to? It sounds irritating. Ah shit. Also, the branch thing feels genuinely scary. All this 1 commit behind blah blah blah ugh. Anyway, for now let's just assume I commit process entries to `master` and leave it at that. Partial merges of one file sound... stupid.

__Prefabs and variations__. Working with prefabs went pretty smoothly - I was able to duplicate the tank prefab, repopulate its data, and then add elements to it to change the game (spotlights for headlights). I was able to change the lighting settings for the scene. That was all fine.

__Scripts and variations__. As per the commit in `experiments-light` it was quite a mission to get established with how to modify the game, especially in terms of scripts. I got into trouble when I tried to add controls for the tanks because I was initially just duplicating the TankMovement script entirely and trying to edit it. But then you end up with a different class name HeadlightsTankMovement which then isn't referenced in any of the other scripts. Shit. I eventually worked out that a fairly clear way to work is to make the main original scripts subclassable (making the various methods `protected virtual` so they can be overridden). That meant I could create my HeadlightsTankMovement as an extension of TankMovement and polymorphism kept everything happy without major work from me. It lead to a fairly clear script, too, which is pleasing. An alternative would have been a brand new script, but that then would have to have been integrated into the GameManager and so on, so I think it may end up cleaner subclassing the scripts that already exist? This felt like quite major and frightening programming philosophy to have to dive into so fast. I should probably congratulate myself on finding _any_ solution, let alone a decent-seeming one moving forward.

__More Git__. Definitely genuinely afraid I'll lose a bunch of work at some point by switching branches expecting it to keep track of files I was working on and then finding out it stomps them somehow. I guess that will just have to happen to me for me to experience it. Also noticed/remembered I have git integration in Atom meaning I could commit from here. I think I'll stick with SourceTree for now.

__Design?__. The big sad face here is that I didn't really enjoy what I was doing as I made the variation. I guess it's just a boring variation - headlights you can turn on and off. Fair enough, it sucks. And if fact you get basically all the information (about it being boring) just by having the headlights at all (turning them on and off didn't add that much - except stealth I guess?). My fear is that I'll be limited to these sorts of hyper-minimalist interventions into the original game and that because the original game is still there and is, frankly, dull - tank shoots tank - it won't be easy/possible to make interventions I think are interesting. So perhaps the fear is I might learn a _lot_ about managing this project, but then find the design implication uninspiring? This comes back to the question of rigour... if I can only work with light (which I adhered to in this first experiment - only added lights to the prefab and light-oriented scripting to the scripts) I won't have enough expressive range. THAT said, I have to keep trying and fucking around. Disco Tank? Spooky Ghost Tank ala Mario Party? Day and Night Tank? Blah blah blah? I mean, they all sound a bit boring too...

__Design?!__ It might be the case that I need to go back to the drawing board a tiny bit just to remind myself and extend on my thinking about why this project is interesting in the first place. Formal experimentation is fine and good _so long as it leads to interesting work_. A dry stick-up-my-ass set of variations that one nods at and says "yes that is a variation" will not sustain me.

And commit.

---

# 2018-01-03 11:11, in which Pippin sits in a café (Odessa) to reflect some more on yesterday and the future of this game, gets into puritanism versus a broader mandate, makes progress, grapples, needs a manifesto

__Well, I.__ Reread yesterday's post-branch entry. Sitting here a little further removed I'm pretty pleased with the technical elements of the work that I managed to get done. (As ever there's a non-zero possibility it won't work out longer term.) It feels like I have a relatively strong grip on what it takes to create new variations of the underlying game via duplicating its Scene and then working with new Prefabs, Scripts, Scene contents in order to make a new version of the game. It's an unusual-feeling way to work because I'm constantly interacting with and dancing around someone else (at least well-written!) code and structures. As a material it definitely _feels_ like something... it has ridges and spikes and smooth patches and satisfying patterns and so forth. Still learning to talk to it though. Thank god its so simple (comparatively).

__CART 415__. How will the students find working with this level of prefab, code, etc.? I've found it pretty intuitive and straightforward, but I imagine it could be a stretch for those of them who are zero-coding (not that they should be, but such people exist). At a bare minimum going through the full tutorial solo and fiddling with it is a great experience for them all to have - kind of can't get it wrong, get to see kind of every aspect of a simple Unity project including good workflow. And then after that the teams can split responsibilities as they see fit, bearing in mind everyone has to design and think about the specific challenge. (Just like I do.)

__Design...__. I'm still left with this issue of how unfun it was to think of and create the headlights variation. Part of that is just the unfunness of the base concept (it's obvious, it's easy to implement, it does change the game but in a totally minimal and predictable way). But part of it feels like it might come down to the Rigour Layer of this project around _only Light_. Most centrally, it seems like Light + different models, say, would potentially be a lot more interesting?

__TANKS! + Light__. It's worth thinking about the game's _current_ relationship to light, right? Basically _TANKS!_ is designed with the idea of light as a totally functional, usability-oriented quality. The overall (ambient and directional) lighting of the scene is chiefly to make sure you can see the tanks and the environment. Yes the shadows look nice etc., but the lighting is all about legibility. The only other light in the game is the point light on the shells which, again, is all about being able to see where shells are a little more clearly. Usability + Light. Functional lighting. Boring lighting. (At this level anyway - it's clear that functional lighting can be pretty fascinating - e.g. Robert's writing about it, that other guy - but with a game this simple it doesn't have much of a function?)

__Light as material__. Obviously I probably just need to play some more before I make grand proclamations, but _only changing Light_ feels like it might be boring and non-expressive. I guess perhaps the key here (as with any of the entities in the ontology) is that if you only interact with a specific entity like Light, it's only ever a small part of the overall game. The result of that is that whatever changes you make, the _overwhelming nature of the game is still the same_. If you turn the lights off it's still _TANKS!_ but without lights. If you rotate the directional light (which I'll do today) it's still just _TANKS!_ with a day/night cycle. Those are perfectly fair interventions and they do alter how that game plays (with light the major implication is about visibility obviously), but they don't really make it into a different game.

__What about that light-shell thing though?__ One of the more complex Light idea I'd had was that you shoot lights, they land and gradually illuminate the landscape, and if you cross into a light that's landed (or just your opponent's light) you are damaged and eventually die. So shooting with shells is replaced by kind of proximity light mines or something. That's pretty much still just a Light intervention, but note that it _isn't_ pure - you still have to significantly modify the behaviour of a shell so that when it hits the ground it stops instead of exploding. That's _not_ anything to do with Light APIs or Lights in the scene per se, it's to do with the physics of the game. And that's a really _simple_ intervention that already "impure".

__Fuck puritanism?__ Okay look. There's something really appealing about being able to say that the methodology for this project is really strict and therefore kind of pure. The idea that you only intervene in the scene/code according to the specific ontological entity of focus gives you a very simple way to figure out what is a legitimate approach and it certainly will tell you something about that ontological entity's impact on the game (and development) experience. But if part of that is that you end up with ultimately uninteresting games that all basically feel like "oh it's just TANKS! again" then is it worthwhile? Another approach would be to say that each variation must _begin from_ and _care most about_ the ontological entity in question. So you start with Light and you only make changes that are explicitly about your focus on Light's relationship to the underlying game. But you don't restrict yourself to only manipulating the material of Light (though obviously it will be a key material). That means you're allowed to change the physics of a shell because it's about how Light behaves in the scene. You would be allowed to, say, change the object composition of the scene to the extent you're interested in create specific shadows. So long as the variation represents an _investigation into Light_ or a _conversation with Light_ you can use a larger vocabulary of words?

__On the other hand___. A respond, though, might be that one should _keep_ the puritanism because if you think about a game like _PONGS_, it generally speaking involved intensely minimalist interventions? But even then those interventions spanned multiple elements of design? They had different UI, visuals, physics behaviours, numbers of entities. In short they used the _entire language of the game_ to explore a _concept about the game_ (a what if, in that case, not anchored to the specifics of the engine or the game itself). Clearly I'm talking myself out of puritanism.

__What am I trying to get out of this?__ Another way to think about all this is to ask what the actual investigation here is - what do I want to find out and experience through the creation of this project? (And actually this is the point where I should write a first manifesto now I think of it. I will.) The idea behind the project at base is to be able to explore Unity. There are a few of reasons for that

- Unity is a fundamental material in videogame creation these days (especially in Indie), it needs to be closely examined and this is a way to engage with that
- Working with the base ontology of a game engine is inherently an interesting thing to claim to be doing regardless of how it turns out (though it could be boring to do obviously)
- I'm wanting to explore The Method further particularly through Git branches
- I'm interested in the idea of the Reflective Practitioner in terms of very explicit 'conversation with materials' and how that's reflected in the material of Unity
- I want to learn Unity better because it's cool and I will be a cool person if I know it

The most intellectually respectable element in this is to do with the "conversation with materials". That that's a way of thinking about the idea of design. Unity is a material. It has submaterials (it even has a thing called a Material for that matter). The ontology in the GameObject menu is a very strict and specific way of regarding a set of Unity's materials that gives a shape to a project.

I had been phrasing this in my mind as being that a specific _TANKS!ES_ collection like Light would mean I was having a "conversation with the Light entity of Unity". That is I would not just be thinking about light but _only talking to Light_. Hence the idea of the hard restrictions on the modifications allowable to _TANKS!_.

But another way to think about this is to say that the GameObject ontology is the _subject of conversation_, while my conversational partner is _Unity itself_. Thus I use the _material of Unity_ to talk and think about a specific submaterial like _Light_. Naturally to think about Light you will likely end up particularly focused on the Light entity in the game, but it's quite possible to think about the nature of Light in Unity by having an absence of Light for example. (Though in that case, assuming you replace Light with Audio, you're veering into a conversation with/about another ontological entity.)

Importantly this approach would free me about to shape the _whole game_ toward the conversational topic (some idea about _Light_ in our current example). It would still be _TANKS!_ beneath, but changed sufficiently that it is more clear what we are trying to think about and address _about Light_. If you need to have no sound, you kill all the sound to better think about Light. And so forth. If you need to have no renderers and only shadows, you do that, because it's about the quality of light.

I'm relatively convinced by this argument. It seems less rigid and more likely to yield work that is capable of being interesting to a player, too. (And, again, if the game is fun at the end, fine fine, but I follow my heart and mind down whatever paths the material shows me.)

__Size small__. I need to remind myself here that it is 100% acceptable that some of these variations are _insanely minimal_. Just switching off all the lights and saying "play that, sucker" is a fine thing to include in the release of this game. It doesn't have to be the case that each variation is epic and changes everything about the game, I just need the _freedom_ to do that if it makes my point (and I need thst freedom to _find_ my point most likely).

__Original included__. The above makes me realise, just by the way, that I should definitely include the original game each time so that people have the point of comparison. Given that each variation is in conversation with that original, it's crucial to be able to look at it as a player and think about what's different.

__Many__. If I want to have a bunch of tiny trivial changes (like, everything's emissive, no lights, headlights, day/night, blah blah) then they can go in there, it's fine. So long as it feels like they make some sort of point and represent something worth experiencing about Unity, go for it.

__Pretty__. And remember that I'm allowed to have purely _aesthetic_ versions. Not every variation has to be some kind of mental masterpiece. Maybe it just looks rad.

__Voluble__. Jesus Christ I'm writing a lot. Too much? This is like a ridiculous amount of words about a game I've barely started. [But I'm grappling, I'm grappling. I'm grap-grap-grappling. I'm grap-grap-grap-grap-grappity-grappling](https://www.youtube.com/watch?v=aR8qtxts1jY).

Aaaand commit.
