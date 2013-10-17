
singleton TSShapeConstructor(TP_KraadDAE)
{
   baseShape = "./TP_Kraad.DAE";
   lodType = "TrailingNumber";
   loadLights = "0";
};

function TP_KraadDAE::onLoad(%this)
{
   %this.renameSequence("ambient", "timeline");
   %this.setSequenceCyclic("timeline", "0");
   %this.addSequence("timeline", "fire", "10", "19", "1", "1");
}
