singleton TSShapeConstructor(PlayerAnim_Disposition_RunDAE)
{
   baseShape = "./PlayerAnim_Disposition_Run.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Disposition_RunDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Run", "130", "149");
}
