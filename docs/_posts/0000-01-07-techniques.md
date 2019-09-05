# Manual refactoring is still refactoring

There are some techniques you can use that allow you to make changes safely

--

#Refactor or rewrite?

Possible to gradually remove usages of problematic code
Replace with other calls or a rewritten version
Keeps code functional while you make a complex change

Notes: Think about it as strangling original code  

--

# Small chunks

<backgroundimage>https://live.staticflickr.com/4048/4679754721_368012b09e_b.jpg</backgroundimage>

+ Commit often, revert on fail, test often
+ Otherwise loose your way during a big refactor
+ Give yourself a safety rope

<p style="font-size: 0.9rem;font-style: italic;"><a href="https://www.flickr.com/photos/54182068@N00/4679754721">"ACC Thursdays Rock Climbing Night - Octopus' Garden wall, Smoke Bluffs near Squamish"</a><span>by <a href="https://www.flickr.com/photos/54182068@N00">iwona_kellie</a></span> is licensed under <a href="https://creativecommons.org/licenses/by/2.0/?ref=ccsearch&atype=html" style="margin-right: 5px;">CC BY 2.0</a><a href="https://creativecommons.org/licenses/by/2.0/?ref=ccsearch&atype=html" target="_blank" rel="noopener noreferrer" style="display: inline-block;white-space: none;opacity: .7;margin-top: 2px;margin-left: 3px;height: 22px !important;"><img style="height: inherit;margin-right: 3px;display: inline-block;" src="https://search.creativecommons.org/static/img/cc_icon.svg" /><img style="height: inherit;margin-right: 3px;display: inline-block;" src="https://search.creativecommons.org/static/img/cc-by_icon.svg" /></a></p>

Notes: Climbers use pitons to make sure they don’t fall too far

--

# Look before you leap

+ Is this tested?
+ Checking coverage
+ Coverage lies
+ Don’t trust tests that haven’t failed

--

### Delete/break code and run the tests
+ Only sure fire way to check code tested
+ Check *why* it fails

--

### Add tests before changing

TODO add background of scaffolding