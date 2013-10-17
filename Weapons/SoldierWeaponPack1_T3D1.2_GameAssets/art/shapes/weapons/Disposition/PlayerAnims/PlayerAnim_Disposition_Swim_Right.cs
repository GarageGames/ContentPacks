singleton TSShapeConstructor(PlayerAnim_Disposition_Swim_RightDAE)
{
   baseShape = "./PlayerAnim_Disposition_Swim_Right.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Disposition_Swim_RightDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Right", "1570", "1629");
}
