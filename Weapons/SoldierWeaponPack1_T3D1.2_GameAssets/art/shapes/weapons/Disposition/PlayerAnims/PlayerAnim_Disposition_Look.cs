singleton TSShapeConstructor(PlayerAnim_Disposition_LookDAE)
{
   baseShape = "./PlayerAnim_Disposition_Look.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Disposition_LookDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Look", "810", "820");
}
