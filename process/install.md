# Install 

## Meta

- Are we too tall?
- Are we too fast?
- Do we like all the extra movement stuff (no)

## Stalin

### 17 July 2026

I put Stalin in a single room with one door for now (partly to test out prefabbing my spaces and carefully baking area lighting etc.) I made him very big, turned him into a rigidbody and dropped him on his face so that he's kind of abjectly face down and huge in a small room.

![](./images/process-screenshots/Screenshot%202026-07-17%20at%2010.46.03.png)

Wondering if, given there's only the one door, he should be even bigger, taking up the whole volume so that he's simultaneous huge and powerful and trapped and sad and in a sense has had his head ripped off (because he's a bust). Unsure for now... there's something *very slightly underwhelming* going on here and I'm not too sure what it is, but it could just be the totally decontextualized thing of this test? Like, if you walked into this room from the context of another room his scale and so on would presumably be more interesting.

I also wonder about having no lighting at all or really minimal lighting so he's just alone in the dark. Am I being too heavy handed with all this? But maybe if he were more mysterious and dark it would be more interesting as well, just a bit of gleaming in the dark, a silhouette etc. It's all in the lighting probably!

### 20 July 2026

Made Stalin as big as he can be while still fiting into the room (diagonally). I think it's kind of good enough for now, though will need a serious revisit.

### 28 July 2026

A serious revisit ensues with "Crimescene Stalin" haha. He's now at monument size (not supersize) and roped off... which I think is starting to work, or may in fact work. The way he falls and stays is face down which means his face is in shadow and cannot be seen which is... kind of good? Could experiment with him face up, but face down may be best.

## Pizza

### 20 July 2026

Installed the pizza in a standard smallest square room but it was too big for a single pizza maxing out one hanging area on the wall facing the door. So made an even smaller room, the smaller possible in fact, and am trying that out. My instinct is that it's kind of good. Might want some velvet ropes around the pizza?

![](./images/process-screenshots/Screenshot%202026-07-20%20at%2014.14.59.png)

Put some in and it increases the aura of the thing I think? Should there be three pizzas across, like a triptych? Do I re-embrace the idea of the three formats (albeda, normal, nothing)? They would fit kind of perfectly and it would also fit with the idea of this being about PBR? I'll try it as it does seem rather important. Still kind of what the "best pizza" in the middle though so it might turn out we need the other walls for it? Ideally not as I like the single wall viewing feel.

## Pictures

### 20 July 2026

Took a first swing by very sensibly thinking prototype instead of final. So I made one (door containing) wall of the pictures kind of alternating but also scales to different dimensions (on X and Z) including not locking proportions so you get weird stretched versions on the vertical and horizontal specifically to fill space in a more interesting way. There's a useful illustration there both on the malleability and mistreatment of assets I think?

![](./images/process-screenshots/Screenshot%202026-07-20%20at%2014.41.09.png)

![](./images/process-screenshots/Screenshot%202026-07-20%20at%2014.46.45.png)

This room pretty clearly works. I don't think it needs the ropes. Could possible use a sofa in the middle. I'll pop one in, something to imply "sit and contemplate" is useful here and holds some space in the centre of the room. I think this room looks like it works.

## Spaceship

### 20 July 2026

For now I'm just throwing it in a room at its maximum fitting scale (it's huuuuuuge otherwise -- Maksim's approach to object scale doesn't always make a lot of sense to me?). It's might be better off a bit smaller to be able to get some distance, but for now I'll try this...

![](./images/process-screenshots/Screenshot%202026-07-20%20at%2015.21.32.png)

It sort of looks fine really. Especially as an earlier, less experimental thing it may make sense like this as I discussed somewhere. It's possible I should lean even harder into the idea of it just as a "model" and so it's scaled down more and behind ropes just as a thing to look at. Let me see that...

![](./images/process-screenshots/Screenshot%202026-07-20%20at%2015.28.36.png)

Yeah I think that's an improvement really. We'll stick with it for now.

## Base Man

My starting ploy is to make a big pile of them and see if that feels like something. I created a rag doll prefab of the guy and then superimposed 100 of them floating above the floor then hit play. They turned into an INCREDIBLE monster of flailing strange limbs that was frankly kind of freaky and just like a horror movie as the engine figured out how to resolve all the bad and fucked up physics involved. Eventually it subsided into a whole lot of base men lying on the floor and piled up and it looks... really kind of good. I'm lighting it right now so we will see. I'm tempted to try to pile them even higher if I can? Like if they could reach the ceiling that would be pretty amazing. I removed all the created rigidbodies and characterjoints so the point is they will just be static and therefore can be baked lighting and therefore can have pretty complex lighting (required by all that occlusion I suppose?) and yet not have it be computationally insane not take any more room particularly than lighting anything else? That's the idea...

![](./images/process-screenshots/Screenshot%202026-07-21%20at%2014.57.18.png)

![](./images/process-screenshots/Screenshot%202026-07-21%20at%2014.57.28.png)

Currently they are not lighting at all properly though which is annoying. We just have a very, very dark room. Looks good without the lighting turned on though which suggests this is worth it...

![](./images/process-screenshots/Screenshot%202026-07-21%20at%2015.02.37.png)

Hmm, well that's frustrating. Still not working. Will continue to look into this and figure it out. The basic visual effect other than the lighting is pretty strong so I do want to keep it this way if remotely possible. Trying it out with just One Man...

![](./images/process-screenshots/Screenshot%202026-07-21%20at%2015.11.55.png)

Maybe some luck here with a Light Probe Group? Seems to be helping the meshes see the light so to speak? Okay well it did the trick even with the big group so.... a win but suggests that there's something about the men (and their ragdolliness) that makes Unity unable to treat them as truly static (since a light probe group as I'm understanding it is about maintaining baked lighting effects for dynamic objects or something). Anyway it does work! SO. Carrying on.

![](./images/process-screenshots/Screenshot%202026-07-21%20at%2015.16.52.png)

![](./images/process-screenshots/Screenshot%202026-07-21%20at%2015.18.49.png)

## Apocalypse Pack (Installation)

As in, let's try to make one of those cool-guy totalizing installations in a gallery space using the Apocalypse pack if we can manage. The scale thing could be a serious issue but let's just see.

Wellll... yeah spent some time on this and already I think it will be workable. A lot of the pieces do miraculously fit inside one of the long rooms, including two of the concrete canopies, the checkpoint, the camper, the boiler room, the "exit" and other stuff. I think this could actually be pretty cool...

For now I've thrown in "enough" stuff to try to light it and walk in it and get a feel. The lighting will need some thought though probably because the canopy blocks out the main area light. That's not a bad thing per se but I'll need some sort of light level underneath. Curious about whether I can walk in the checkpoint or not. Worst case I can give it some specific colliders myself if the mesh version wouldn't work.

This one might balloon the build a bit but I think it's extremely worthwhile because it's a kind of "as intended" nod to the art of assets. I'll work hard to make something actually plausible so that to the extent I can (not much) it'll feel a bit like a "real game" with the museum kind of peeking through.

The floor is an obvious failing point... is there a way to improve that? Maybe just retexture this floor to a concrete texture that must be in here somewhere to avoid the sense of it being too museumy. Or just cover it with fencing sections... but that doesn't make a ton of sense.

![](./images/process-screenshots/Screenshot%202026-07-21%20at%2016.15.50.png)

![](./images/process-screenshots/Screenshot%202026-07-21%20at%2016.17.10.png)

![](./images/process-screenshots/Screenshot%202026-07-21%20at%2016.17.55.png)

![](./images/process-screenshots/Screenshot%202026-07-21%20at%2016.18.09.png)

![](./images/process-screenshots/Screenshot%202026-07-21%20at%2016.18.23.png)

Yeah it's not there but it's getting there! I believe this can be done. Building for webgl to see how bad that is... 27.4MB! That's-a nothing!

## Dead Man in the Bag

Well I sat at the optomestrist's today trying to visualize a good display of the Dead Man in a Bag. I had this idea eventually of a roped off room you cannot enter that he's in, maybe dimly or unlit, maybe with a spotlight.

Got home and made that and... well he looks tiny and insignificant and not remotely like a problem. And I clearly feel I want him to feel powerful and ominous. Why doesn't he? 

![](./images/process-screenshots/Screenshot%202026-07-22%20at%2017.13.12.png)

![](./images/process-screenshots/Screenshot%202026-07-22%20at%2017.13.16.png)

How small would a small enough room have to be? How else can it work? At a certain scale it will look ludicrous and there will still be a lot of room. I can play with the lighting but I think that it's the space.

Do I have him in the same room but inaccessible? I think he had more gravitas when he was at the end of a long room and you could get closer to him? The empty space had a meaning because it was space to traverse whereas right now I just have visual empty space which is... empty.

Hmmm. Minivision just now of the asset teleporting to different locations suddenly as the light flashes. Trickery to make it more something... but there's something amiss here for now.

### Day 2 (23 July 2026)

Having another run at this. A few more ideas I thought about while on the train home from university:

- Be in the same (small) room but he's still roped off
- Return to that idea of him at the end of a long room (no sofas?)
- The idea of changing the materials of the room so that it's less museum-y (concrete walls and floor?)
- Flickering lights, lights go out (in big room) when you get to him and you have to find your way back by the light of the only doorway?
- Construct a complete separate room out of just concrete planes that you enter to see him, could even have an L shaped bed in it for Schneider vibes?

Probably all worth a go until I find something?

...

Trying the long room with a spotlight and... it's not really working. Also it's reminding me of the issue I seem to have with a long seam running down rooms between floor tiles... which... ugh? Probably won't *kill* me but I do not love it.

Made a small room out of planes and a random close-enough texture and... it won't light. I did have some joy killing the weird light seems by completely eliminating environment lighting but that's probably bad in some other way. It really doesn't help in general that we have 1-sided meshes for the stupid museum. I can wrap it all in a box I guess to see if that helps because otherwise the desert will presumably be in trouble for lighting later on if I stick with it.

Ah yes, broken things are broken. Broken broken broken. So easy to break them. How the fuck to show this fucking dead man in a fucking bag. My fucking favourite fucking asset. Fuck fuck fuck.

![](./images/process-screenshots/Screenshot%202026-07-23%20at%2015.08.56.png)

![](./images/process-screenshots/Screenshot%202026-07-23%20at%2015.10.28.png)

Hilariously the origin one with the roped door is *still* probably the best in terms of at least looking a little creepy when you see him from a distance through the doorway. Nothing else has been working *at all*. Probably wise to work on something else for a while.

### Day 3 (27 July 2026)

Tried out a small room with one door and the man in a corner with a sofa leaned over the top of him and a spotlight. Getting kind of strangely elaborate? I think it does better than other stuff?

The scale of the room, even the smallest room I can reasonably make (because of requirments around walls with doors and the corner pieces) still seems colossal relative to the man.

![](./images/process-screenshots/Screenshot%202026-07-27%20at%2014.23.10.png)

I'm still fond of the concrete narrow space which would evoke Schneider? Funny how hard this is!! I'm trying it out now with... some success? Grabbed some concrete by [patternpanda](https://patternpanda.org/concrete.html) as a starting point and have been probuilding a simple structure inside a gallery room to create the shape I want. I just lit it and it's so much better I'm amazed. I can and will mess around more with how the structure works but:

![](./images/process-screenshots/Screenshot%202026-07-27%20at%2014.55.21.png)

I do think we have a winner here. I'll close off the ends of the t and look at making it more claustrophic. I do quite like having the open ceiling to definitely let you see that you're still in a typical museum room, but a really low ceiling could also be quite good. I can try both out. I can at least make the walls much height and that should do something. Clamp the ends, narrow everything as much as I can. I think we have it. Maybe he could be around a corner? Though the view towards him is really nice I feel... I'll play.

Building for webgl and a push.

### Day 4 (28 July 2026)

Narrowed the space, capped the ends, made the walls slightly diagonal per Jim, could do more of that kind of slight uncanny stuff. I think will work. I'm obviously going to rebuild from scratch later though.

Still no 100% there. I think the view we get is now perhaps too narrow. Maybe the hall can start narrow and widen a bit. Also when you come to actually stand near the body it's still kind of underwhelming. May be that you shouldn't be able to get to it at all. What about a platform? Zoom is our friend here too. Maybe the player's height being reduced helps?

## Barrels

Popped some barrels in a room, stacked them a bit, baked the lighting... it looks kind of good. The key idea here was to have them be blocking some of the doors so you would see them in two ways, from inside the room and then also as blocking your way through a particular doorway...

![](./images/process-screenshots/Screenshot%202026-07-24%20at%2014.54.12.png)

![](./images/process-screenshots/Screenshot%202026-07-24%20at%2015.02.45.png)

So I mean... yeah it works just totally fine I think. The lighting is even quite nice in this because I accidentally used a strength 1 light which is quite weak, huh.

## Desert Night

Started working on this without worrying about the integration of the museum. In my mind I'm seeing the museum inside a large concrete box with a single door. I'm seeing the idea that when you get the door it auto rotates you to look ahead and walks you out then disappears the museum... should work.

Hard to make the desert feel the way I want lighting wise which is funny. I should probably learn the proper ways but for now I'll flail.

I think it's... ok. I'm concerned that the truth is that this asset is just too fucking big to include. I'll build a webgl after the next bake and see what it's adding to the basic 15MB or so. If it's ridiculous I might abandon, though without it I'm at risk of not having an ending.

Every bake takes a really long time because it's a reall big desert. I don't really need the desert to be so big but I don't think I can straightforwardly scale it back. Maybe I'll look into that as having more of a 2x2 or even 1x1 desert segment would like be better than this mammoth thing. Though then I run the risk of weird horizon shit. But yeah it would be nice not to be dealing with quite so much of it.

Another fuckup with a baked directional light jeeeeeeesus. So I'm just gonna export a webgl of this to see and then give up for a sec and move on. It's only 15.4MB so... well that's good.

Also just noticed the cargo ship wasn't static so no wonder it was too dark. I dunno man. Lighting is hard. I'm gonna play with it a touch more then stop for the day on this. It's better than it has been. THat's about as much as I can say...

![](./images/process-screenshots/Screenshot%202026-07-28%20at%2015.11.34.png)

One last experiment with baking the directional light (moon) and then I swear I will stop doing this. Hey maybe it finally worked... or maybe it looked identical to the real time version... whatever.

![](./images/process-screenshots/Screenshot%202026-07-28%20at%2015.15.06.png)

A mere 13.6MB too so thaaaaaat's nice.

## Humanoid Creature

### Day 1 (28 July 2026)

Trying out the most basic idea of the creature idling in the centre of the room with its back to you. Trying out having it be extra big. Trying to figure out the lighting situation since an area light (which I'm using) is bake only and the creature is animated so cannot receive baked light...

Maybe we play with a shadow? I baked the light onto it with a light probe and it looks really nice, but the lack of a shadow is frustrating...

HMMMMM. Well something to address tomorrow. Always nice to have... something to address... tomorrow.

Creature *does* look really nice at a large scale. Room still looks kind of barren though.

![](./images/process-screenshots/Screenshot%202026-07-28%20at%2018.53.26.png)

### Day 2 (29 Juy 2026)

Did get the spotight working. Yeah... this is good. The fact of the movement is actually a huge difference maker. It's the only thing moving in the world so it's quite quite striking in fact.

![](./images/process-screenshots/Screenshot%202026-07-29%20at%2013.42.55.gif)

I quite love it now. The idea of the shadow being the first thing would be neat if it's possible? Maybe a bit obvious? Bit of a nod to Bioshock? Bit of a whatever? Bit of an interference with whatever is in the previous room?

Building webgl in part to see if the shadow stays or whether I have build quality problem stuff to address... 19.5MB... nope no shadow and looks almost comically cartoony. But that bit's okay. The shadow sucks and I'll have to work on it.

![](./images/process-screenshots/Screenshot%202026-07-29%20at%2013.47.28.png)

Just found myself writing in the commit and will include here too: try adding a seat in front of the creature as a way of suggesting to stop and look. But also the weirdness of the threat and the fear versus the prolonged contemplation... good stuff?