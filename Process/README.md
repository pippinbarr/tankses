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
