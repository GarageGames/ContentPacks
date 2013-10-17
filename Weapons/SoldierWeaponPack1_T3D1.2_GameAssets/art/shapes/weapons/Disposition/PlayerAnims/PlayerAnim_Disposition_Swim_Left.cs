singleton TSShapeConstructor(PlayerAnim_Disposition_Swim_LeftDAE)
{
   baseShape = "./PlayerAnim_Disposition_Swim_Left.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Disposition_Swim_LeftDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Left", "1480", "1539");
}
