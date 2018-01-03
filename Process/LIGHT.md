# Day and Night, Play and Sleep

In commit 2c13c2d0322a8879b38de5470d3ab40fe0d753c3 I created a version in which the sun (directional light) rotates and therefore creates a cycle of day and night in the world. Shadows length, in turns to night, there's moonlight, then the sun comes up again and on we go. It was boring in the immediate term, but it made me think about rhythms of life that take place in the day versus at night. In particular it started to make me think of the idea that at night the tanks would go home. And in fact I naturally thought about the tanks as _children_ who have to go home (or they'll get in trouble with their parents). They can go out and play again the next morning.

Also still possible to think more generally about the implications of day and night as human concerns and how that might be translated to the world of the game. For instance it cold be the tanks' _job_ to engage in combat, making money for their family, etc. Just concerned by being overelaborate and not having the time to really make these things.

I like this because
- it trivialises the actual combat by framing it in something implied to be larger.
- The tanks being children makes their play inconsequential in a really final-feeling manner.
- It's like the game is double-infantilised, which feels like it removes more of the sting?

What would I need?
- Need houses for the tanks to go to. Really suburban houses would be funny. Maybe they live next door to each other.
- Need to inform the player that they have to go home. Could be direct text with a timer. Could be a voice from the houses calling the children back in ("Red" and "Blue"?)
- I guess you could ask whether the tanks should even have health in this scenario? Should they "die" or should they just play on until they have to go home?

Issues...
- Does this stray too far from the idea of a conversation with light? Is it overwrought? Is it too complex while simultaneously not being all that interesting? Very narrative, not very formal? More like a free association with a specific property of light?


# Light Shells

I'm implemented the basics of this in commit 40a69e23c165aae27ed3a7402f717466c1504c47 (just now noticed these are not being auto converted to commit links which is sad, renders them kind of stupid, oh well). The idea here is that you replace the projectile itself with a light and instead of exploding it just rests on the environment itself, therefore adding to the overall light of the scene.

I've had ideas around this become a new style of the tanks fighting - they fight with light, where going into the light reduces health etc. Or alternatively the opposite - going into the light is how you score points, or something. But again this feels like really trivial intervention, just recasting one typical game element (a 3D model of a shell with a rigidbody) with another (a light source). Yeah it's aesthetically different, but not _that much_.

I need to think more deeply than this about what light does and try to work from there? Or is _TANKS!_ overwhelming in its kind of rhetoric and world view? This will need some thought.
