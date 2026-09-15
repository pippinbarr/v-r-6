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

...

Later on I did a sweep of the barrels room that I think is alright? I wonder if I'll get in trouble for not perfectly balancing them on each other? As in the light baking bit will be sad at me or something? Will see. Baking now. The room basically looks nice. (Next is Dead Man which feels like it'll be a challenge.)

## 9 September 2026

I've been a bit patchy on my commit timing and writing here such that I'm kind of out of sync with reporting what I'm doing and what I'm thinking, which is unusual for me, but I put it down to the chaos of the semester starting. Here is me trying to at least reset and get to grips with where things stand and where they will head next...

Where are we. Back there I see that I was on barrels, so since then we've got

### Dead Man

I spent ages getting the Dead Man room to work, it was really irritating. I got the code working in a prototyping area kind of smoothly, but then in the real situation (notably with an actual concrete space) it turns out the character controller was having a lot of trouble (I think) colliding with the walls and teleporting around. I did eventually get there, though it felt like I'd already tried the solution that eventually worked so I don't have a *deep* understanding of it tbh. But that said the friction of it did force me to read a bunch about character controllers and how they override the larger world's transformations and so on.

I ran into the realisation that with the area light version that you would see the lighting change when the room rotated because it's baked. I switched to a point light and that seems to be working nicely. At this point you go down the hallway and it's seamless I think in terms of the spin.

It's satisfying. It will even be more satisfying with some kind of ... sound. Maybe a v r 1 reference sound while you're in there? That could be sweet.

### Humanoid Creature

Installed it in the room after Dead Man. Nothing much to say. I once again lost control of the shadow and so on but just needed more intensity on the realtime spotlight and it works. It's nice and glossy. It idles. I decided against any ropes. It *could* be riding the plain end a bit too much, but I think it's probably alright. Some kind of "viewing platform" could be kind of awesome?

### Apocalypse Pack

I've made a closer-to-correct version of this now and it looks pretty cool. Needs colliders but it is largely holding together. Kind of hard to light. Could it use a strobing pointlight somewhere just to give it that apocalyptic look perhaps? Unsure. Bits of it are currently too bright. There will definitely have to be a pretty involved lighting pass on the whole game anyway. 

### Paintings

Went back and properly put paintings on all the walls in a serious grid. It looks... satisfactory. Should I put a huge two versions up as well, leaning against the walls for close study? Perhaps so.

### Generally

Well apart from the gift shop and the desert we have an almost complete sweep of the whole thing holding together. I'll do those last two things first and then return to the little bit and pieces needed. There's the VO element to consider too and hopefully that will push it over the top in terms of it being a little more engaging on the front of thinking about process and the nature of the assets.

## 11 September 2026

### Paintings

Added giant paintings to the paintings room because it just felt like there needed to be a version you can study more closely. Even though the resolution is going to be poor?

### Pizzas

Added three more giant pizzas in each corner... there are ways in which I can see it almost as a Rothko room, just with pizzas. I thought for a bit about a kind of leaning set of pizzas telescoping out of the corner, but it did end up feeling all that interesting. Rothko Pizza. Good business idea too.

### To dos

I am going to update the to-dos, it is getting smaller and more pointy.

## 14 September 2026

Pokes at it all a bit today and made a couple of nice additions. Well, not that impressive, but I did:

- spotlight the two big paintings in the paintings room and it makes for a much nicer room
- spotlight stalin but then there was no shadow casting? Why?
- created the start of a wall text that I think should actually be beside the door as you exit the spaceship room, I'll just move it now

All told it's sort of a limping progress but a progress nonetheless.

## 15 September 2026

Spent quite a bit of time over today working on the base men, feeling incredibly dissatisfied, poking at them, pushing them around with cube shapes as if I was spreading peanut butter, dragging them into new positions to cover the floor, nothing working, sadness mounting.

Then I wondered about returning to that idea of isolating ragdolling base men away from the big group so that they're in those contorted positions "for no reason" and it looks a bit like a static moment in a dance and reminds me (perhaps too obviously??) of Kristallijn.

BUT importantly it actually looks good and kind of beautiful and it's good. It's also just far less extravagant than the other one, less worries about evoking death camps too.