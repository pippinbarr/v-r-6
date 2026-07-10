# Curation

Wherein I write about the specific pieces for inclusion, the philosophical/aesthetic perspective of the show, and especially the taxonomic potential for exhibiting these kinds of works (models, animations), with things like animation, speed, scale, lighting, rotation, translation, and so on.

## Taxognome (Started 9 July 2026)

### Big questions

- "Intended use" versus "pure museum"?
- Creative representation of curator versus artist?

### File Size

We have some curatorial constraints potentially around file sizes. If we want a web build, we have to be judicious about which assets to include. The Humanoid Creatures take up 50MB *each* which probably blows our size budget almost immediately. How big is too big? The Pizza is 13MB. Good value.

### Translations / Rotations

This is a big one, but fundamentally any of these assets can be positioned anywhere in space because it's digital. They can float in the air, be attached to the ceiling, a wall, blocking a doorway, lying on the floor, etc. 

I could adhere to traditional museum translations and rotations by having the assets behave like statues (generally on the floor, vertical) and paintings (generally on the wall, vertical). That would keep things *extremely* vanilla and I suppose there's a worry in me that it ends up so dry that it's not really worth it. *But* am I being silly not having faith that a more traditional presentation gives the audience room to contemplate the assets as statues and paintings? 

In the end this is one of the really key decisions, particularly around the three ideas of: traditional (asset on a plinth), physically possible (asset lying on the floor in a corner), impossible (asset floating in the air)?

Part of the "answer" is almost certainly to make three (or more) rooms and just to try displaying the *same* asset in multiple ways to see what works, aka prototyping.

### Scales

I think this is a surprisingly powerful one. Changes in scale immediately do a few things:

- They point out the arbitrariness of scale in a virtual world in terms of brute possibility
- They can create strange contrast effects between asset and environment (more for the below section on relations)
- Large scales allow for the idea of close examination of details in assets, which feeds into the idea of being there to *appreciate* the craft involved (though also introduces difficulty of fitting things into the space, or how to show details of something without flooding the space with the rest of it - suggests testing again)
- Tiny scales seem kind of ridiculous? Can't imagine it being worthwhile, though the idea of tiny little monsters running around is funny
- "Correct" scales are a thing in terms of the relationship between an asset and the space - they generally import into the scene at a "correct" (1 unit is 1 meter) kind of scale?

The big display opportunity here is around scaling things up to allow you to see details, and scaling things down to allow something very large (e.g. a huge ship) to fit into the space.

And there's a difference between the actual act of scaling and asset and the *sense of scale* you get (again I suppose this is more the below), but I'm particularly thinking of that idea of having the tanker fill an entire room.

### (Spatial) Relations

This is getting really big, but of course you don't translate/rotate/scale (TRS) something in isolation - rather it's about what that means relative to the surrounding environment. Examples being

- The ship that fills a room (impacts navigation)
- The body the blocks a door (impacts navigation)
- The creature leaning back against a wall
- The stack of creatures in the corner
- A grid of assets in a room
- An asset on the ceiling
- A giant pizza leaning on a wall
- A pizza you walk on

And so on - it's kind of infinite. If the project is first of all about display MB's work then the spatial relations should be supportive of that. But even that is kind of a two parter:

- You want the work to be available to *look at* as an object (demonstrating the craft)
- You maybe want the work to be availabl to *experience as intended* (demonstrating a further artist layer)
- You want the museum itself to be interesting enough that someone stays and explores (partly a question of faith in the audience, the anxiety of attention-seeking)

So there's a philosophical decision to make about the nature of museum. One that I can *probably* find through a combination of thinking about intent (things like writing the [Why](./why.md) a few times) *and* "in the room" by trying different configurations to see what strikes me as correct.

### Albedo / Bump map / Other texture stuff? / Materials

When I put the pizza into the museum at one point because Felix and I thought that would be funny I did a version where there's a pizza with no albedo (and I'm realizing now should have had a pizza with no bump as well - trying it now).

This seems like a must for at least one asset (the pizza works oddly well, but I should try on a bunch) where the point is to illustrate the difference between the mesh/model and the different elements of texturing. It's a part of the craft the museum can reveal. Maybe an animated thing is even better because there's something about seeing it still "alive" that's maybe nice?

### Lighting / Shadows

There's a lot of potential light stuff, including selective light per room, per asset, ...

- Moonlight?
- Daylight?
- No light?
- Ambient light?
- Coloured light?
- Point light?
- Spot light?
- Emissive light?
- Area light?

Lighting is important both in terms of showing off the craft - different kinds of lights impact the way we see a model. A creature or bodybag in the darkness reads differently to one that's well lit. A spotlight asks you to look differently to just a room (point) light versus daylight versus moonlight and so on. They can all be tried out. I do like the idea of a moonlit room through the skylight. 

How the fuck do we stop the shadows cast by the ceiling which looks *horrible*. Most obviously with no directional light but then how to do moonlight or standard room light? Area light in that position maybe? Looking into whether I can even use Area lights though since maybe not compatible with the render pipeline I can use for webgl which I am still clinging to... hmmmmm. Trying it out now to see if I can get a nice red area light baked and working in webgl. I think it's the "obvious" solution and so long as almost everything is static it'll be ok as a solution for some rooms? That or I need to close off the ceiling.

So most of all I should think about things like room lighting in terms of whole room, and then the question of whether some spots or that kind of thing make sense in the museum context?

(I have these little flashes of... should the whole exhibition be of a *single asset* or is that a different project? It's different and worthwhile. Added to my game ideas list for later on.)

Lighting, as ever, is kind of huge, but if I keep to the question of how to show off the stuff we should be good.

Increasingly I suppose there should be some kind of balance between the craft element (showing off mesh, albedo, bump map, animation) and intended experiential (horror lighting and environment) and then maybe some playful stuff (cargo ship in a museum space).

Just noticed that the ceiling windows are *emissive* and that's part of the scene's lighting! So maybe that's the other way instead of an area light? Though seems pretty expensive though... maybe that's fine or maybe an area light kind of does the trick better that a ton of small emissive ones which seems ultra expensive? Turned off the emission and we'll see what the result is.

### Sounds (lack of)

Right now we have footsteps and nothing else. I don't necessarily hate that, though better footsteps (and reverb) for the space would make sense to me? I don't think I want to get into sound because MB doesn't do sound. Unless I want a single room *with* sound that's in line with the potential feeling stuff where you could have something ominous sounding (Shepherd Tone?) in a space with a body bag or something. Blurring into the "horror museum" stuff but it's possible that's still reasonable.

(How many rooms is this thing? I think I don't want to get too out of control in the end... there's a lot of intricacy to think about here.)

### Animations

The creatures (and presumably other assets) are animated and presumably MB made (or at the very least intended) those animation. There are a *lot* of animations too - the creatures have something like 40 they can do. There's merit to the full cycle to point at "animation" but then also to singular animations to allow/encourage closer examination (which gets to the idea of slow motion applied to those).

- Range of animations in one
- Range of creatures one per animation
- Slow motion of a specific animation (running in place?)

I'm particularly into the question of animation. If I am eventually to have a separate thing that is *just one asset* I should save some ideas for that. I'm seeing some similarities here though with *v r 3* in that you could imagine a series of spaces that's just one asset in many formats, and a different series where it's different assets in one format.

I think I'd like something more playful/freeform right now though, less rigid, with the "one asset" thing later on, so I'll save hyper-formal repetitions with variation for that? Or that's my operating idea.

There are more "world-facing" animation ideas like a creature *walking around* in a space which are worth contemplating because they represent an experiential level.

### Interactions

I have a feeling this "goes too far" but we could imagine an aspect of the museum being an interactive thing where maybe you could even "fight" a creature, say, and have it react. Which *is* a part of the intended experience of these assets (presumably that's why those animations exist - implied interactions and responses) but... gosh it's a deep dive?

### Combinations

All of the above could well end up being combined! So that you end up with an asset with no albedo lit in a specific way playing an animation in slow motion, say. And there's the argument (as with *v r 3*) that the combination is meaningful and impactful. And that it's very much connected with what it means to use assets in a game.

I find this kind of exhausting - it's something I could address in a more formal museum/exhibition, but maybe not here? Unless v r solo includes that idea as well which... it's just starting to sound too big to me.

### Variations

Consider the Humanoid Creature(s) and their set of 41(!) animations. In *v r $4.99* I displayed them chained as a dance, so that's one way (variation over time). But you could also have 41 instances of a creature (in one room?) each demonstrating an animation. Or you could have a "living" creature that's reactive and simulating more the intended use. (Which is also situations/combinations.)

### Situations

This kind of gets at the point that these assets were created to be used *in a game* not in isolation and that that's part of their meaning. So you would ideally want at least some display situations where you're at least pointing to that idea.

It occurs to me that one way is things like the musical dead man in a bag stuff above. Also the idea of maybe a tableau with a creature towering over an asset of a person (looking scared? I don't think they do but that's funny in another way, like a crash test dummy). So that's the kind of Museum of Natural History version.

As I write this I'm also thinking... it would make sense to have some real language around what I want to *say* with a given room either in a kind of audio trigger or written down (audio trigger is appealing but takes up space... but maybe really ratty quality?)

### Infrastructures

The question of plinths and frames and stanchions. Given the specifics of the environment stanchions seem reasonable, but plinths get hard because how do *I* make them? (Just made a little plinth and chucked a wood material from the museum on it and... looks totally fine. There's also a white wood that looks quite nice. Creature in a t-pose on the plinth definitely has something.)

The question of didacts and wall texts and general interpretive/informative language. Which I was getting to in Situations - I think I want didacts with everything just to point to where they come from (either in the world or separately) but I'm increasingly drawn to maybe an audio file per room that would trigger and give a sort of story of the curation/idea behind it? Adds a kind of personal element to the story...