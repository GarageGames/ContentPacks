
singleton TSShapeConstructor(TP_KralDAE)
{
   baseShape = "./TP_Kral.DAE";
   lodType = "TrailingNumber";
   loadLights = "0";
};

function TP_KralDAE::onLoad(%this)
{
   %this.renameSequence("ambient", "timeline");
   %this.setSequenceCyclic("timeline", "0");
   %this.addSequence("timeline", "Fire", "10", "19", "1", "0");
}
