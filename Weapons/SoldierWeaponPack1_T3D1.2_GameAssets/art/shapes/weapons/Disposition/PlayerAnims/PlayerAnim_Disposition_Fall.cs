singleton TSShapeConstructor(PlayerAnim_Disposition_FallDAE)
{
   baseShape = "./PlayerAnim_Disposition_Fall.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Disposition_FallDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Fall", "930", "959");
}
