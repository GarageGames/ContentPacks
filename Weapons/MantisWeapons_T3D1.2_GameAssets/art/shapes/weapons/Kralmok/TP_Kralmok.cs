
singleton TSShapeConstructor(TP_KralmokDAE)
{
   baseShape = "./TP_Kralmok.DAE";
   lodType = "TrailingNumber";
   loadLights = "0";
};

function TP_KralmokDAE::onLoad(%this)
{
   %this.renameSequence("ambient", "timeline");
   %this.setSequenceCyclic("timeline", "0");
   %this.addSequence("timeline", "fire", "10", "19", "1", "0");
}
