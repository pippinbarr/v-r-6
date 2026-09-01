# Build

Effectively this is the journal for building out the actual game now that things are prototyped (mostly).

## 5 August 2026

Spent some time this afternoon just literally plugging together the rooms shapes needed for the flow I came up with here:

![](./images/process-screenshots/Screenshot%202026-07-30%20at%2014.41.28.png)

With the added gift shop taking up a slot of the Apocalypse Pack's footprint (which will doubtless have consequences and maybe I should have prototyped out, although it sort of "is what it is" in terms of dealing with the space available for that particular room anyway.)

![](./images/process-screenshots/Screenshot%202026-08-05%20at%2014.19.41.png)

I'm generating the lighting now just to see what kind of build size I eventually get and to be able to take a walk through all the spaces (though now I think about it the Dead Man Dead End will cause an issue.)

The lighting is... taking a while, which is somewhat discouraging in terms of thinking of a version where I'm tweaking it and so on. Maybe area lights are just completely not my friend. Maybe I need point lights which I can run real time and then bake later for gorgeousnesses? I'll look at that as I go. It really would be nice to be able to run something approaching accuracy in realtime while I build knowing it will be roughly the sense of the final.

The area light is... really nice though. So let's just see for now. I see we're at 32MB in lightmaps at the moment and not done. Hmmm. Well it may prove prohibitive for webgl... I assume webgl will be a lot smaller if we light realtime. Maybe I "just" install both lighting systems and make it somewhat easy to switch them based on how things go... I don't think lightmaps this massive are gonna make sense, unless they shrink as part of the webgl build.

![](./images/process-screenshots/Screenshot%202026-08-05%20at%2014.31.41.png)

Looks lovely though. For now I will very much take that. Looking forward to installing the pieces and getting a first real walk through.

Walked. It's kind of cool. Light levels are varied by mistake (some very dark rooms) and... well actually it's very nice and adds some variation to the experience that would be lacking overwise... worth playing with further.

It's pretty barren feeling – admittedly with nothing in it, but I wonder if it will still feel kind of sterile after the install. Can only find out by doing it, but there's a tingle of that being a problem.

Another next step is to put this in the desert in a building to get a sense of that part of it. 

Building webgl now to see how outlandish that is or isn't... 

... it is 27.8MB! Well that's pretty relieving! So far no game breaking size issue.

## 1 September 2026

Huh, I guess I haven't been writing as much here as I should, though a lot of it is just me on vacation for two weeks.

I just got done trying out a different approach to the Base Man room which got bigger and turns out to be really irritating to light (in this version of Unity? Dunno). I'm now working with a roped off area and then a thick layer of men poured inside that – I'm getting better and better at pouring layers of men. I think it mostly worked though I'm not suuuuuuper happy with the shapes around the ropes because there's a box collider there instead of a mesh collider so it's... imperfect. I might well remake it another time with mesh colliders then switch back to box for the game proper since I can bake/freeze where they end up with the more complex physics. It looks... fairly good. I'm lighting them with two point lights which then inevitably suck and create visible seams on the walls which I'm combatting by shifting the material properties a bit but... well we'll see we'll see.

Anyway I think this basic concept, a pool of men, works. So I'll carry on.